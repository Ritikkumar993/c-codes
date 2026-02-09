using System.Collections.Concurrent;
public static class ParallelLetterFrequency
{
    public static Task<Dictionary<char, int>> Calculate(IEnumerable<string> texts)
    {
      return Task.Run(()=>{
          var freq = new ConcurrentDictionary<char, int>();

          Parallel.ForEach(texts, text =>{
             foreach(char ch in text){
              char lower = char.ToLower(ch);
                 if(Char.IsLetter(lower)){
                     freq.AddOrUpdate(lower,1,(_, count)=>count+1);
                 }
             } 
          });

          return freq.ToDictionary(k =>k.Key,v => v.Value);
      });
        
        throw new NotImplementedException("You need to implement this method.");
    }
}