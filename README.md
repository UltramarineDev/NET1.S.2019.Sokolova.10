1. Переобразовать методы расширения класса ArrayExtension Day 7 в обобщенно-типизированные методы - done

public static TSource[] Filter<TSource>(this TSource[] source, IPredicate<TSource> predicate) { }

public static TResult[] Transform<TSource,TResult>(this TSource[] source, ITransformer<TSource, TResult> transformer) { }

public static TSource[] SortBy<TSource>(this TSource[] source, IComparer<TSource> comparer) { } 

2. Проверить работу полученных методов, используя в качестве тест-кейсов постановки задач из Day 7

3. Набор целочисленных зачений представлен массивом строк, каждая из которых является представлением соответствующего целого числа в p-ичной (2<=p<=16) системе счисления. Получить набор целочисленных значений.

4. Репозиторий вопросов и ответов