### В чем разница между int.Parse() и Convert.ToInt32() в C#?
**int.Parse** преобразует строку (*string*) в *int* (если может).
**Convert.ToInt32** преобразует в int значение любого типа, из перечисленных [здесь](https://learn.microsoft.com/ru-ru/dotnet/api/system.convert.toint32?redirectedfrom=MSDN&view=net-7.0#overloads "Convert.ToInt32 Метод"). *boolean*, *double*, *float* и т.д. А самое главное, может преобразовать экземпляр любого класса, реализующего **IConvertible**.

Если говорить о строках, то **Convert.ToInt32** внутри всё равно использует **int.Parse**. Но есть нюанс:
Что происходит в этом кусочке кода ?

```C#
public static int ToInt32(String value) {
    if (value == null)
        return 0;
    return Int32.Parse(value, CultureInfo.CurrentCulture);
}
```

Для неинициализированной строки *int*.*Parse* выбросит исключение, **Convert.ToInt32** вернет 0.

Если кратко и понятно, когда мы вводим какое-то число, то оно принимает стринговое значение. *Parse* в этом случае преобразует *string* в *int* (можно еще в *double*). Ни в какие другие типы мы больше преобразовать не сможем. *Convert* же преобразует любой тип переменной в любой другой тип. То есть если ты твердо знаешь, что будет *integer*, то можно использовать *Convert.ToInt32* или *Convert.ToInt16*. По сути внутри метода *Convert.ToInt32* лежит *Parse*. Только если методу *Convert.ToInt32* передать **NULL**, то программа выведет 0, а вот если **NULL** передать *Parse*, то будет ошибка.

#### NULL

> Никуда не указывать | указывать в никуда