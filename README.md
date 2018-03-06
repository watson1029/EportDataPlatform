电子口岸数据平台
=====
### 概述
1. DotNetCore + EntityFrameworkCore
2. Oracle + MsSql混合喂养
### 更新日志
[TODO.md](TODO.md)
### 解决方案
* 主程序
  * 报关单接口 src/EportDataPlatform.IEntry
* 依赖项目
  * 数据连接 dependent/EportDataPlatform.DataAccess
  * 数据实体 dependent/EportDataPlatform.Entity
---
## 安装调试
1. 安装 DotNetCore2.0.3 [https://dotnet.github.io/](https://dotnet.github.io/)
2. 下载源码 git clone https://github.com/watson1029/EportDataPlatform.git
3. 恢复依赖包 dotnet restore 
4. 运行 dotnet run
---
## 部署
### DotNet Core Runtime 2.0.3
### DataBase.MsSql2008R2
---
