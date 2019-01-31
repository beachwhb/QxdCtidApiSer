using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using AxRZFWTestLib;
using Qxd.Sdk.Ctid2;
using QxdCtidApiSer.Ctids.Dtos;

namespace QxdCtidApiSer.Ctids
{
    public class CtidRecogAppService : QxdCtidApiSerAppServiceBase, ICtidRecogAppService
    {
        private readonly IRepository<CtidRecog, long> _ctidRecogRepository;

        public CtidRecogAppService(IRepository<CtidRecog, long> ctidRecogRepository)
        {
            _ctidRecogRepository = ctidRecogRepository;
        }
        public List<CtidRecogDto> GetCtidRecogs()
        {
            var ctidRecogs = _ctidRecogRepository.GetAllList();
            //var qp = new QueryParam
            //{
            //    name = "王海滨",
            //    idcard = "362330198209067199",
            //    cammerPhoto = "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",
            //    recogCode = "0x42"
            //    //recogCode = Ctid.RecoRequestMode.Eleven;
            //};
            //OnlineFr(qp);

            return ObjectMapper.Map<List<CtidRecogDto>>(ctidRecogs);
        }

        /// <summary>
        /// 2 项信息+人像 0x42
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public ResultModelDto GetTwoAndFace(GetTwoAndFaceInput input)
        {
            var queryParam = new QueryParam
            {
                name = input.Name,
                idcard = input.IdCardNo,
                cammerPhoto = input.PhotoBuffer,
                recogCode = Ctid.RecoRequestMode.Eleven
            };

            ResultModelDto result = OnlineFr(queryParam);
            return result;
        }

        /// <summary>
        /// 4 项信息+人像 0x42
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public ResultModelDto GetFourAndFace(GetFourAndFaceInput input)
        {
            var queryParam = new QueryParam
            {
                name = input.Name,
                idcard = input.IdCardNo,
                beginDate = input.UserLifeBegin.ToString("yyyyMMdd"),
                endDate = input.UserLifeEnd.ToString("yyyyMMdd"),
                cammerPhoto = input.PhotoBuffer,
                recogCode = Ctid.RecoRequestMode.Nine
            };

            ResultModelDto result = OnlineFr(queryParam);
            return result;
        }

        /// <summary>
        /// 人像+网证
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public ResultModelDto GetFaceAndWz(GetFaceAndWzInput input)
        {
            var queryParam = new QueryParam
            {
                authCode = input.AuthCode,
                cammerPhoto = input.PhotoBuffer,

                CtidIndex = @"B19FABEA60504FB65F3AA087ED0CE155239A7D8EF9D1BC694F31D0B78E0C48B9.wzMIIB1gYKKoEcz1UGAQQCA6CCAcYwggHCAgEAMYHPMIHMAgEAMD0wMTELMAkGA1UEBhMCQ04xETAPBgNVBAoTCEdMQ1RJRDAxMQ8wDQYDVQQDEwZHTENBMDECCH96wSriUCnPMAsGCSqBHM9VAYItAwR7MHkCIQCVeCUcHBGOzwAN0pKxTunD9+UHNkPJjUbndZ3t6jdvCwIgCaA8VqaEYlLRVtnn7jByr+spvhwOCZWdBVQFodkIkoMEII0IOGOVpZNvpRk4zHbGdzwU/oaXGcOExXMUHzrIOQ24BBAwXnXFmBjPgn2UfrF+7pFAMIHqBgoqgRzPVQYBBAIBMAkGByqBHM9VAWiAgdDG6iMWZAszwVYSX2WRT7O7SbaMAxRFYTg1Sp+OxRUr2OZPjDWKAwysLBEB2sMYCprFLEgDk2h+ZTPSz2LQbhY8xuojFmQLM8FWEl9lkU+zu8bqIxZkCzPBVhJfZZFPs7vG6iMWZAszwVYSX2WRT7O7xuojFmQLM8FWEl9lkU+zu8bqIxZkCzPBVhJfZZFPs7vG6iMWZAszwVYSX2WRT7O7xuojFmQLM8FWEl9lkU+zu8bqIxZkCzPBVhJfZZFPs7vGo0se/hleDHuUPAiPpASA",
                CtidInfo = @"AwCxn6vqYFBPtl86oIftDOFVI5p9jvnRvGlPMdC3jgxIuTIwMTgwMTIyMTIxMzMzMTQ5AQFsUYlb6JAsewBOFHh2ekBiACAAIAAgACAAIAAgACAyADAAMQA4ADAAMQAyADIAMgAwADMAMQAwADIAMQA1AAjPuPOn8hbjDIX3VHYQu7uiQBJVB83QZT9UA8Kiea9asZ+r6mBQT7ZfOqCH7QzhVSOafY750bxpTzHQt44MSLlQEj+4ml0s19KyUxEAlNyoD/nl80cw0sK2CT22/a6rYQABMEQCIEvGvRzkjuZbxYwLRpm0YCGGnMDPEEn/Sy8XRJrCOeJLAiAUTeZTOkaBzHGlzv1cARcrqsMIboC3sIDti6NXUtKMxwAA",
                
                recogCode = Ctid.RecoRequestMode.Six

            };
            ResultModelDto result = OnlineFr(queryParam);
            return result;
        }



        /// <summary>
        /// 获取认证码数据
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string GetRzm(GetRzmInput input)
        {
            var axRzfwTest = new AxRZFWTest();//报错：当前线程不在单线程单元中，因此无法实例化 ActiveX 控件“654495dd-3d10-4fe7-afb8-5fb0e106050d”
            var result = axRzfwTest.RZM_ShuRu(input.Radrom.Length.ToString(), input.Radrom, input.AuthCode);
            return result;
        }


        /// <summary>
        /// 提交认证。正确保存结果并提示返回信息，错误不保存并提示
        /// </summary>
        /// <param name="qp"></param>
        private ResultModelDto OnlineFr(QueryParam qp)
        {
            var ctid = new Qxd.Sdk.Ctid2.Ctid(new InitSetParam());
            var recogModel = new CtidRecogModel();

            var resultModel = ctid.GetCtidRecogModel(qp, ref recogModel);

            //如果错误
            if (resultModel.ResultCode != 0)
            {
                Logger.Info("认证失败: " + qp);
                return ObjectMapper.Map<ResultModelDto>(resultModel);
            }
            

            //成功就把结果写入数据库
            try
            {
                var ctidRecog = new CtidRecog
                {
                    CustomerNo = recogModel.CustomerNO,
                    AppName = recogModel.AppName,
                    TerminalNo = recogModel.TerminalNO,
                    TimeStamp = recogModel.TimeStamp,
                    BusinessSerialNumber = recogModel.BusinessSerialNumber,
                    ResultCode = recogModel.ResultCode,
                    ResultMessage = recogModel.ResultMessage,
                    AuthResult = recogModel.AuthResult,
                    Similarity = recogModel.Similarity,
                    ReservedData = recogModel.ReservedData
                };



                //var ctidRecog = ObjectMapper.Map<CtidRecog>(recogModel);

                _ctidRecogRepository.Insert(ctidRecog);//插入到数据库

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return ObjectMapper.Map<ResultModelDto>(resultModel);
        }

        /// <summary>
        /// 导出认证数据
        /// </summary>
        public void GetCtidRecogToExecl()
        {
            //导入数据

            var ctidRecogs = _ctidRecogRepository.GetAllList();

        }


        /// <summary>
        /// 测试
        /// </summary>
        /// <returns></returns>
        public string Test()
        {
            return "Hello!";
        }
    }
}
