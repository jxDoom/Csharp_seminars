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