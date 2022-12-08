using System;
namespace Permutation;
public class Program
{
          public static List<string> Permutation(List<string> word)
        {
                    int length = word.Count;
                    string s = string.Join("", word);
                    while(!word.All(x => x.Length == length))
                    {
                              List<string> wordList = new List<string>();
                              for(int i = 0; i < word.Count; i++)
                              {
                                        var w = word[i];
                                        var except = s.Except(w).ToList();
                                        for(int j = 0; j <except.Count; j ++)
                                        {
                                                  wordList.Add(w + except[j]);
                                        }
                              }
                              word = wordList;
                    }
                    return word;
        }
}