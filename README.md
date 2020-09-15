# AspNetCore3xJwtAuthApiExample
ASP.NET Core 3.1-JWT身份验证API

### 简介

1. 示例API接口。
   - /users/authenticate 验证账号，返回Jwt身份验证令牌和用户详细信息，cookie添加刷新令牌
   - /users 受保护的接口，401未授权
   - /users/refresh-token 通过cookie刷新令牌获取新的jwt令牌和新的刷新令牌
   - /users/1/refresh-tokens 获取指定用户所有的刷新令牌，包括活动和撤销的令牌
   - /users/revoke-token 通json token值或cookie刷新令牌，进行撤销刷新令牌，使其不可再用于生成jwt令牌


### 知识点

1. 自定义验证属性
2. 自定义验证token中间件



### 引用Nuget

1. Microsoft.AspNetCore.Authentication.JwtBearer

2. System.IdentityModel.Tokens.Jwt

3. Microsoft.EntityFrameworkCore.InMemory
   


