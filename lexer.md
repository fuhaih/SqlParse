
## 关键字
* SELECT
* FROM
* WHERE
* AND
* OR
* GROUP
* ORDER
* BY
* CASE
* WHEN
* THEN
* ELSE
* END
* declare
* in
* like

## token
* Keyword

SelectKeyWord、FromKeyWork等

* NumericLiteralToken 12.6

* StringLiteralToken 'test'

sql中字符串是单引号开始的

* IdentifierToken 标识符(方法名、字段名等) 

* DotToken .
* SemicolonToken ;
* CommaToken ,
* OpenBracketToken [

* CloseBracketToken ]

这两个符号考虑下可能和IdentifierToken合并，sql中标识符可以使用[]来括起来

* PlusToken +
* MinusToken  -
* AsteriskToken *
* SlashToken /
* PercentToken %
* CaretToken ^
* AmpersandToken &
* ExclamationToken !
* TildeToken ~
* EqualsToken =

* BadToken @
这个可以考虑为ParameterToken,sql中变量需要用@前缀，全局变量就是@@，这样是为了区分参数和列名

* HashKeyToken #
这个也可以考虑为表变量token，sql中的局部表变量以#为前缀，全局表变量就是##

* MinusMinusToken --
这个在sql中是注释