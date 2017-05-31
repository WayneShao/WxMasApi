using System;
using System.Collections.Generic;
using WxMasApi.Common;
using WxMasApi.Model;

namespace WxMasApi
{
    public class WxMasService : IWxMasService
    {
        /// <summary>
        /// 通过身份证号码查询患者信息
        /// </summary>
        /// <param name="idcardNum"></param>
        /// <returns></returns>
        public List<UserInfo> GetUserInfoByIdcardNum(string idcardNum)
        {
            return //JsonHelper.Serialize(
                new List<UserInfo>
                {
                    new UserInfo
                    {
                        Name = "陈家辉",
                        PatientId = "00001"
                    }
                };
            //);
        }

        /// <summary>
        /// 通过PatientId获取患者当前的所有预约结果
        /// </summary>
        /// <param name="patientId"></param>
        /// <returns></returns>
        public List<Reservation> GetUserReservationItems(string patientId)
        {
            return //JsonHelper.Serialize(
                new List<Reservation>
                {
                    new Reservation
                    {
                        Id = "1",
                        Date = Convert.ToDateTime("2017/5/30"),
                        BeginTime = Convert.ToDateTime("2017/5/30 08:00:00"),
                        EndTime = Convert.ToDateTime("2017/5/30 08:15:00"),
                        Department = "肛肠科",
                        Status = "0",
                        AppliedDatetime = Convert.ToDateTime("2017/5/29 10:23:58"),
                        AppliedDepartment = "肛肠科",
                        AppliedDoctor = "赖小燕",
                        CheckSite = "前列腺",
                        ClinicDiagnose = "前列腺炎",
                        StudyFee = "$500",
                        ExamName = "前列腺全切术"
                    },
                    new Reservation
                    {
                        Id = "2",
                        Date = Convert.ToDateTime("2017/5/30"),
                        BeginTime = Convert.ToDateTime("2017/5/30 14:00:00"),
                        EndTime = Convert.ToDateTime("2017/5/30 14:15:00"),
                        Department = "妇科",
                        Status = "0",
                        AppliedDatetime = Convert.ToDateTime("2017/5/29 10:23:58"),
                        AppliedDepartment = "超声科",
                        AppliedDoctor = "赖小燕",
                        CheckSite = "子宫",
                        ClinicDiagnose = "子宫肌瘤",
                        StudyFee = "$500",
                        ExamName = "子宫全切术"

                    }
                };
            //);
        }

        /// <summary>
        /// 通过日期和检查单号来获取当天可预约时段
        /// </summary>
        /// <param name="date"></param>
        /// <param name="reservationId"></param>
        /// <returns></returns>
        public List<TimeRange> GetTimeRangesInDate(DateTime date, string reservationId)
        {
            return //JsonHelper.Serialize(
                new List<TimeRange>
                {
                    new TimeRange
                    {
                        BeginTime = Convert.ToDateTime("2017/5/30 14:00:00"),
                        EndTime = Convert.ToDateTime("2017/5/30 14:15:00")
                    },
                    new TimeRange
                    {
                        BeginTime = Convert.ToDateTime("2017/5/30 14:20:00"),
                        EndTime = Convert.ToDateTime("2017/5/30 14:35:00")
                    },
                    new TimeRange
                    {
                        BeginTime = Convert.ToDateTime("2017/5/30 14:40:00"),
                        EndTime = Convert.ToDateTime("2017/5/30 14:55:00")
                    },
                    new TimeRange
                    {
                        BeginTime = Convert.ToDateTime("2017/5/30 15:00:00"),
                        EndTime = Convert.ToDateTime("2017/5/30 15:15:00")
                    },new TimeRange
                    {
                        BeginTime = Convert.ToDateTime("2017/5/30 15:20:00"),
                        EndTime = Convert.ToDateTime("2017/5/30 15:35:00")
                    }
                };
            //);
        }

        /// <summary>
        /// 预约检查单到某个时段
        /// </summary>
        /// <param name="reservationId"></param>
        /// <param name="range"></param>
        /// <returns></returns>
        public bool AppointmentReservation(string reservationId, TimeRange range)
        {
            return true;
        }

        /// <summary>
        /// 取消检查单的预约
        /// </summary>
        /// <param name="reservationId"></param>
        /// <returns></returns>
        public bool CancelReservationAppointment(string reservationId)
        {
            return true;
        }

        /// <summary>
        /// 签到项目
        /// </summary>
        /// <param name="reservationId"></param>
        /// <returns></returns>
        public bool SignReservation(string reservationId)
        {
            return true;
        }
    }
}
