using Abp.Application.Services;
using Abp.Application.Services.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;
using siasun.MCS.ACSEntitys.Dtos;



namespace siasun.MCS.ACSEntitys
{
    /// <summary>
    /// 应用层服务的接口方法
    ///</summary>
    public interface ITP_ARVStatusEntityAppService : IApplicationService
    {
        /// <summary>
		/// 获取的分页列表集合
		///</summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<PagedResultDto<TP_ARVStatusEntityListDto>> GetPaged(GetTP_ARVStatusEntitysInput input);


		/// <summary>
		/// 通过指定id获取ListDto信息
		/// </summary>
		Task<TP_ARVStatusEntityListDto> GetById(EntityDto<string> input);


        /// <summary>
        /// 返回实体的EditDto
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<GetTP_ARVStatusEntityForEditOutput> GetForEdit(string input);


        /// <summary>
        /// 添加或者修改的公共方法
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task CreateOrUpdate(CreateOrUpdateTP_ARVStatusEntityInput input);


        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task Delete(EntityDto<string> input);

		
        /// <summary>
        /// 批量删除
        /// </summary>
        Task BatchDelete(List<string> input);

        //// custom codes

        //List<TP_ARVStatusEntityListDto> GetAll();

        //// custom codes end
    }
}
