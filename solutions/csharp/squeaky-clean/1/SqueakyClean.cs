using System.Text;
public static class Identifier
{
    public static string Clean(string identifier)
    {
        bool kebab=false;
        StringBuilder sb = new StringBuilder();
        foreach(char ch in identifier){
            if(ch==' '){
                sb.Append('_');
            }
            if(char.IsControl(ch)){
               sb.Append("CTRL");
            }
            if(ch=='-'){
                kebab=true;
            }
               
            if(char.IsLetter(ch) && !(ch>='α' && ch<='ω')){
                if(kebab){
                    sb.Append(char.ToUpper(ch));
                    kebab=false;
                }
                else{
                    sb.Append(ch);
                }   
            }      
        }
        return sb.ToString();

    
        throw new NotImplementedException($"Please implement the (static) Identifier.Clean() method");
    }
}
