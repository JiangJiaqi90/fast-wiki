---
sidebar_position: 4
---

# 支持的Semantic Kernel语言

Semantic Kernel计划为以下语言提供支持：

- C#
- Python
- Java ([在此处可用](https://github.com/microsoft/semantic-kernel/tree/experimental-java))

虽然内核的整体架构在所有语言中都是一致的，但我们确保每种语言的SDK遵循各自的常见范例和风格，使其感觉原生且易于使用。

## 可用功能

今天，并非所有功能在所有语言中都可用。以下表格显示了每种语言中可用的功能。🔄符号表示该功能已部分实现，请查看相关说明栏以获取更多详细信息。❌符号表示该功能在该语言中尚未可用；如果您希望在某种语言中实现某项功能，请考虑[为项目做出贡献](https://learn.microsoft.com/zh-cn/semantic-kernel/get-started/contributing)或[提交问题](https://learn.microsoft.com/zh-cn/semantic-kernel/get-started/contributing#reporting-issues)。

### AI服务

展开表

| 服务             |  C#  | Python | Java | 说明                               |
| :--------------- | :--: | :----: | :--: | :------------------------------- |
| 文本生成         |  ✅   |   ✅    |  ✅   | 例如：Text-Davinci-003        |
| 文本嵌入         |  ✅   |   ✅    |  ✅   | 例如：Text-Embeddings-Ada-002 |
| 聊天完成         |  ✅   |   ✅    |  ✅   | 例如：GPT4, Chat-GPT          |
| 图像生成         |  ✅   |   ❌    |  ❌   | 例如：Dall-E                  |

### AI服务端点

展开表

| 端点                     |  C#  | Python | Java | 说明                                                        |
| :----------------------- | :--: | :----: | :--: | :----------------------------------------------------------- |
| OpenAI                   |  ✅   |   ✅    |  ✅   |                                                              |
| AzureOpenAI              |  ✅   |   ✅    |  ✅   |                                                              |
| Hugging Face推理API     |  🔄   |   ❌    |  ❌   | 即将推出到Python，.NET尚未覆盖所有场景 |
| Hugging Face本地         |  ❌   |   ✅    |  ❌   |                                                              |
| 自定义                   |  ✅   |   🔄    |  ❌   | 需要用户在其应用程序中定义服务架构 |

### 分词器

展开表

| 分词器 |  C#  | Python | Java | 说明                                                        |
| :----- | :--: | :----: | :--: | :----------------------------------------------------------- |
| GPT2   |  ✅   |   ✅    |  ✅   |                                                              |
| GPT3   |  ✅   |   ❌    |  ❌   |                                                              |
| tiktoken|  🔄   |   ❌    |  ❌   | 即将推出到Python和C#。可以通过`pip install tiktoken`手动添加到Python中 |

### 核心插件

展开表

| 插件                     |  C#  | Python | Java | 说明 |
| :----------------------- | :--: | :----: | :--: | :---- |
| 文本内存插件             |  ✅   |   ✅    |  🔄   |       |
| 对话摘要插件             |  ✅   |   ✅    |  ✅   |       |
| 文件IO插件               |  ✅   |   ✅    |  ✅   |       |
| Http插件                 |  ✅   |   ✅    |  ✅   |       |
| 数学插件                 |  ✅   |   ✅    |  ✅   |       |
| 文本插件                 |  ✅   |   ✅    |  ✅   |       |
| 时间插件                 |  ✅   |   ✅    |  ✅   |       |
| 等待插件                 |  ✅   |   ✅    |  ✅   |       |

### 规划者

展开表

| 规划者              |  C#  | Python | Java | 说明          |
| :------------------ | :--: | :----: | :--: | :------------- |
| 规划对象模型       |  ✅   |   ✅    |  🔄   |                |
| 基本规划者         |  ❌   |   ✅    |  ❌   |                |
| 行动规划者         |  ✅   |   ✅    |  🔄   | 正在开发中 |
| 顺序规划者         |  ✅   |   ✅    |  🔄   | 正在开发中 |
| 逐步规划者         |  ✅   |   ✅    |  ❌   |                |

### 连接器

展开表

| 内存连接器 |  C#  | Python | Java | 说明                                                        |
| :---------- | :--: | :----: | :--: | :----------------------------------------------------------- |
| Azure AI搜索|  ✅   |   ✅    |  ✅   |                                                              |
| Chroma      |  ✅   |   ✅    |  ❌   |                                                              |
| DuckDB      |  ✅   |   ❌    |  ❌   |                                                              |
| Milvus      |  🔄   |   ✅    |  ❌   |                                                              |
| Pinecone    |  ✅   |   ✅    |  ❌   |                                                              |
| Postgres    |  ✅   |   ✅    |  ❌   | 矢量优化需要[pgvector](https://github.com/pgvector/pgvector) |
| Qdrant      |  ✅   |   🔄    |  ❌   | 在特性分支中进行审查                                 |
| Redis       |  ✅   |   🔄    |  ❌   | 矢量优化需要[RediSearch](https://redis.io/docs/stack/search) |
| Sqlite      |  ✅   |   ❌    |  🔄   | 矢量优化需要[sqlite-vss](https://github.com/asg017/sqlite-vss) |
| Weaviate    |  ✅   |   ✅    |  ❌   | 目前仅支持Python 3.9+，3.8即将推出          |

### 插件

展开表

| 插件                                                      |  C#  | Python | Java | 说明                                                        |
| :--------------------------------------------------------- | :--: | :----: | :--: | :----------------------------------------------------------- |
| MsGraph                                                   |  ✅   |   ❌    |  ❌   | 包含OneDrive、Outlook、ToDos和组织层次结构的插件 |
| 文档和数据加载插件（如pdf、csv、docx、pptx）              |  ✅   |   ❌    |  ❌   | 目前仅支持Word文档                       |
| OpenAPI                                                   |  ✅   |   ❌    |  ❌   |                                                              |
| Web搜索插件（如Bing、Google）                             |  ✅   |   ✅    |  ❌   |                                                              |
| 文本分块器                                                |  🔄   |   🔄    |  ❌   |                                                              |

## 关于Python SDK的说明

在初始开发阶段，出于速度和功能对等性的考虑，忽略了许多Python最佳实践。该项目现在正在进行重构，以提高代码质量。

为了使内核尽可能轻量化，核心pip软件包应具有最小的外部依赖关系。另一方面，SDK不应重新发明已经存在的成熟解决方案，除非存在重大问题。
