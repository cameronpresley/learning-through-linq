using System;
using System.Collections.Generic;

namespace LinqExploration
{
  public static class IEnumerableExtensions
  {
    public static IEnumerable<U> Select<T, U> (this IEnumerable<T> source, Func<T, U> mapper) 
    {
      foreach (var a in source)
        yield return mapper(a);
    }
    public static IEnumerable<T> Where<T>(this IEnumerable<T> source, Func<T, bool> filter)
    {
      foreach (var a in source)
      {
          if (filter(a)) 
            yield return a;
      }
    }
    public static bool Any<T>(this IEnumerable<T> source, Func<T, bool> predicate)
    {
      foreach (var a in source)
      {
        if (predicate(a)) 
          return true;
      }
      return false;
    }

    public static bool Any<T>(this IEnumerable<T> source)
    {
      return source.Any(_=>true);
    }
    public static bool All<T>(this IEnumerable<T> source, Func<T, bool> predicate)
    {
      foreach (var a in source)
      {
        if (!predicate(a)) 
          return false;
      }
      return true;
    }
    public static T FirstOrDefault<T>(this IEnumerable<T> source, Func<T, bool> predicate)
    {
      foreach (var a in source)
      {
        if (predicate(a)) 
          return a;
      }
      return default(T);
    }
    public static T FirstOrDefault<T>(this IEnumerable<T> source)
    {
      return source.FirstOrDefault(_=>true);
    }

    public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
    {
      foreach(var t in source)
        action(t);
    }
    public static List<T> ToList<T>(this IEnumerable<T> source)
    {
      var result = new List<T>();
      result.AddRange(source);
      return result;
    }
  }
}