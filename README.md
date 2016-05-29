## SSIS Helper - SSIS Batch Processing
[![License MIT](https://img.shields.io/badge/License-MIT-blue.svg "MIT")](https://github.com/guoliang-dev/SSISHelper/blob/master/LICENSE)

SSIS batch processing utils build with C#.

### Why?
it was 2012, I was working on an ETL project which has hundreds DTS packages. my responsibility are understanding all legacy DTS package(SQL 2000) and designing SSIS packages(SQL 2005).

Managing hundreds of SSIS packages by `clicking` is **boring** and **risky**. I cannot guarantee that I can apply the exactly same logging configuration to hundreds SSIS packages by clicking.

I'm a developer and I believe there must be a way to get ride of these repeating clicks. after I found the [Microsoft.SqlServer.Dts.Runtime API](https://msdn.microsoft.com/en-us/library/microsoft.sqlserver.dts.runtime.aspx), I started to build this tool to save my life by reducing boring clicking.

### Features
(I removed the UI I build in 2012) it'll be a command line tool and you can use the APIs in your application.  typical features:
> given a path, find all packages , for each package:
  - find all SQL servers used by all packages
  - update password
  - update connection name
  - generate `dtexec` command line
  - setup logging
  - check protection level, etc,.
