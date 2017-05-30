using System;
using System.Collections.Generic;
using System.ServiceModel;
using WxMasApi.Model;

namespace WxMasApi
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IWxMasService”。
    [ServiceContract]
    public interface IWxMasService
    {
        [OperationContract]
        string GetUserInfoByIdcardNum(string idcardNum);

        [OperationContract]
        string GetUserReservationItems(string patientId);

        [OperationContract]
        string GetTimeRangesInDate(DateTime date, string reservationId);

        [OperationContract]
        bool AppointmentReservation(string reservationId, TimeRange range);

        [OperationContract]
        bool CancelReservationAppointment(string reservationId);

        [OperationContract]
        bool SignReservation(string reservationId);
    }
}
