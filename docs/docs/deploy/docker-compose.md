---
sidebar_position: 3
---

# 使用Docker-Compose快速构建

在项目根目录下创建`docker-compose.yml`文件，内容如下：

```yaml
version: '3.8'  # 可以根据需要使用不同的版本
services:
  fast-wiki-service:
    image: registry.cn-shenzhen.aliyuncs.com/fast-wiki/fast-wiki-service
    container_name: fast-wiki-service
    user: root
    restart: always
    ports:
      - "8080:8080"
    build: 
      context: .
      dockerfile: ./src/Service/FastWiki.Service/Dockerfile
    volumes:
      - ./wwwroot:/app/wwwroot/
    environment:
      - OPENAI_CHAT_ENDPOINT=https://api.openai.com
      - OPENAI_CHAT_EMBEDDING_ENDPOINT=https://api.openai.com
      - OPENAI_CHAT_TOKEN={您的TokenKey}
      - OPENAI_CHAT_MODEL=gpt-3.5-turbo
      - OPENAI_EMBEDDING_MODEL=text-embedding-3-small
      - ASPNETCORE_ENVIRONMENT=Development

  postgres: # 当前compose服务名
    image: registry.cn-shenzhen.aliyuncs.com/fast-wiki/pgvector:v0.5.0 # 拉取的数据库镜像
    container_name: postgres  # 容器运行的容器名称
    restart: always  # 开机自启动
    environment:  # 环境变量
      POSTGRES_USER: token  # 默认账号
      POSTGRES_PASSWORD: dd666666 # 默认密码
      POSTGRES_DB: wiki # 默认数据库
      TZ: Asia/Shanghai  # 数据库时区
    volumes:
      - ./postgresql:/var/lib/postgresql/data # 将PostgreSql数据持久化

  fast-wiki-server:
    image: registry.cn-shenzhen.aliyuncs.com/fast-wiki/fast-wiki-server
    container_name: fast-wiki-server
    restart: always 
    ports:
      - "2180:8080"
    build: 
      context: .
      dockerfile: ./src/Web/FastWiki.Web.Server/Dockerfile
    environment:
      - FAST_WIKI_SERVICE=http://知识库api的ip:8080 
```

修改`docker-compose.yml`中的`{您的TokenKey}`为您的OpenAI Key，如果需要使用自己的代理则修改`OPENAI_CHAT_ENDPOINT`和`OPENAI_CHAT_EMBEDDING_ENDPOINT`为自己的代理地址，`FAST_WIKI_SERVICE`为`fast-wiki-service`的ip地址，因为上传的文件会保存在`fast-wiki-service`的wwwroot目录下，所以需要将`fast-wiki-service`的ip地址替换为自己的ip地址（容器内不要使用127.0.0.1），才能外部正常访问。

```shell
docker-compose up -d
```

即可快速构建并启动服务。
