﻿namespace FastWiki.Service.Domain.Wikis.Repositories;

/// <summary>
/// 知识库仓储
/// </summary>
public interface IWikiRepository : IRepository<Wiki, long>
{
    /// <summary>
    /// 获取知识库列表
    /// </summary>
    /// <param name="keyword"></param>
    /// <param name="page"></param>
    /// <param name="pageSize"></param>
    /// <returns></returns>
    Task<List<Wiki>> GetListAsync(string? keyword, int page, int pageSize);
    
    /// <summary>
    /// 获取知识库数量
    /// </summary>
    /// <param name="keyword"></param>
    /// <returns></returns>
    Task<long> GetCountAsync(string? keyword);
    
    /// <summary>
    /// 获取知识库详情列表
    /// </summary>
    /// <param name="wikiId"></param>
    /// <param name="keyword"></param>
    /// <param name="page"></param>
    /// <param name="pageSize"></param>
    /// <returns></returns>
    Task<List<WikiDetail>> GetDetailsListAsync(long wikiId, string? keyword, int page, int pageSize);
    
    /// <summary>
    /// 获取知识库详情数量
    /// </summary>
    /// <param name="wikiId"></param>
    /// <param name="keyword"></param>
    /// <returns></returns>
    Task<long> GetDetailsCountAsync(long wikiId, string? keyword);
}