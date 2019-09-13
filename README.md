## Tasks

:heavy_check_mark: 1. Преобразовать методы расширения класса ArrayExtension Day 7 в обобщенно-типизированные методы
```
public static TSource[] Filter(this TSource[] source, IPredicate predicate) { }

public static TResult[] Transform<TSource,TResult>(this TSource[] source, ITransformer<TSource, TResult> transformer) { }

public static TSource[] SortBy(this TSource[] source, IComparer comparer) { }
```
<br/>
:heavy_check_mark: 2. Проверить работу полученных методов, используя в качестве тест-кейсов постановки задач из Day 7<br/><br/>

:heavy_check_mark: 3. Набор целочисленных значений представлен массивом строк, каждая из которых является представлением соответствующего целого числа в p-ичной (2<=p<=16) системе счисления. Получить набор целочисленных значений.
