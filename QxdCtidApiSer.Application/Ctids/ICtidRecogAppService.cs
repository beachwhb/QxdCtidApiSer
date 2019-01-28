using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using QxdCtidApiSer.Ctids.Dtos;

namespace QxdCtidApiSer.Ctids
{
    public interface ICtidRecogAppService : IApplicationService
    {
        /*
         * 
         GetTasksOutput GetTasks(GetTasksInput input);
         void UpdateTask(UpdateTaskInput input);
         void CreateTask(CreateTaskInput input);

         */

        /// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        List<CtidRecogDto> GetCtidRecogs();

        /// <summary>
        /// 2 项信息+人像 0x42
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        CtidRecogDto GetTwoAndFace(GetTwoAndFaceInput input);

        /// <summary>
        /// 4 项信息+人像 0x42
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        CtidRecogDto GetFourAndFace(GetFourAndFaceInput input);

        /// <summary>
        /// 人像+网证 0x06
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        CtidRecogDto GetFaceAndWz(GetFaceAndWzInput input);


        string Test();

    }
}
