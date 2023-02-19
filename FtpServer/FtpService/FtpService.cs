using Ftp.InterfaceService.InterfacesBase;
using Grpc.Core;
using ProtoFtp;
using static ProtoFtp.FTPService;

namespace FtpServer.FtpService
{
    public class FtpService : FTPServiceBase
    {
        private IUnitOfWorkFtpService _UnitOfWorkFtpService;
        public FtpService(IUnitOfWorkFtpService UnitOfWorkFtpService) { _UnitOfWorkFtpService = UnitOfWorkFtpService; }
        public override async Task<ResponseFile> UploadFile(IAsyncStreamReader<RequestFile> requestStream, ServerCallContext context)
        {
            try
            {
                var data = new List<byte>();
                while (await requestStream.MoveNext())
                {
                    data.AddRange(requestStream.Current.Data);
                }
                var Rand = new Random().Next(10, 10000).ToString();
                var namefile = "F" + Rand + "" + DateTime.Now.Hour.ToString() + "" + DateTime.Now.Minute.ToString() + "" + DateTime.Now.Second.ToString();
                File.WriteAllBytes("/fileupload/" + namefile + ".jpg", data.ToArray());
                return new ResponseFile() { IsOK = true };

            }
            catch (Exception)
            {
                return new ResponseFile() { IsOK = false };
            }
        }

        public override async Task<ResponseInsertFtp> Insert(RequestInsertFtp request, ServerCallContext context)
        {
            try
            {
                var fileFtp = request.FilesFtp;
                var _fileFtp = new Ftp.ClassDomain.Domains.FilesFtp()
                {
                    FileFtp_DateTime = DateTime.Parse(fileFtp.FileFtpDateTime),
                    FileFtp_FileName = fileFtp.FileFtpFileName,
                    FileFtp_RefID = fileFtp.FileFtpRefID,
                    FileFtp_SettingsFtp_ID = fileFtp.FileFtpSettingsFtpID,
                };
                await _UnitOfWorkFtpService._IFilesFtpService.Insert(_fileFtp);
                if (await _UnitOfWorkFtpService.SaveChange_DataBase_Async() > 0)
                {
                    return new ResponseInsertFtp()
                    {
                        FileFtpID = _fileFtp.FileFtp_ID,
                        Status = new ProtoFtp.Status
                        {
                            StatusCode = ProtoFtp.StatusCode.Status200,
                            StatusMessage = StatusMessage.Success,
                        }
                    };
                }
                return new ResponseInsertFtp()
                {
                    FileFtpID = 0,
                    Status = new ProtoFtp.Status
                    {
                        StatusCode = ProtoFtp.StatusCode.Status400,
                        StatusMessage = StatusMessage.Failed,
                    }
                };
            }
            catch (Exception)
            {
                return new ResponseInsertFtp()
                {
                    FileFtpID = 0,
                    Status = new ProtoFtp.Status
                    {
                        StatusCode = ProtoFtp.StatusCode.Status400,
                        StatusMessage = StatusMessage.Failed,
                    }
                };
            }
        }

        public override async Task<ResponseGetAllFtp> GetAll(RequestGetAllFtp request, ServerCallContext context)
        {
            var _ResponseGetAllFtp = new ResponseGetAllFtp();
            try
            {
                var SettingID = request.FileFtpSettingID;
                var RefID = request.FileFtpRefID;

                var _FileFtps = await _UnitOfWorkFtpService._IFilesFtpService.GetAll(F => F.FileFtp_RefID == RefID && F.FileFtp_SettingsFtp_ID == SettingID);
                if (_FileFtps != null)
                {
                    foreach (var fileFtp in _FileFtps)
                    {
                        var FileFtp = new FilesFtp()
                        {
                            FileFtpID = fileFtp.FileFtp_ID,
                            FileFtpRefID = fileFtp.FileFtp_RefID,
                            FileFtpFileName = fileFtp.FileFtp_FileName,
                            FileFtpDateTime = fileFtp.FileFtp_DateTime.ToString(),
                            FileFtpSettingsFtpID = fileFtp.FileFtp_SettingsFtp_ID,
                        };
                        _ResponseGetAllFtp.FilesFtps.Add(FileFtp);
                    }

                    _ResponseGetAllFtp.Status.StatusCode = ProtoFtp.StatusCode.Status200;
                    _ResponseGetAllFtp.Status.StatusMessage = ProtoFtp.StatusMessage.Success;
                }
                else
                {
                    _ResponseGetAllFtp.FilesFtps.Add(new FilesFtp() { });
                    _ResponseGetAllFtp.Status.StatusCode = ProtoFtp.StatusCode.Status400;
                    _ResponseGetAllFtp.Status.StatusMessage = ProtoFtp.StatusMessage.Failed;
                }
            }
            catch (Exception)
            {
                _ResponseGetAllFtp.FilesFtps.Add(new FilesFtp() { });
                _ResponseGetAllFtp.Status.StatusCode = ProtoFtp.StatusCode.Status400;
                _ResponseGetAllFtp.Status.StatusMessage = ProtoFtp.StatusMessage.Failed;
            }

            return _ResponseGetAllFtp;

        }
    }
}
