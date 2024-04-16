using System.Text;

namespace JokesWebApp.Services;

public class NonsenseService : INonsenseService {

    public string ConvertToLeet(string input) {
        StringBuilder output = new StringBuilder(); 
        
        for (int i = 0; i < input.Length; i++) {

            if (i % 2 == 0) {
                output.Append(char.ToLower(input[i])); 
            }
            else {
                output.Append(char.ToUpper(input[i])); 
            }
        }

        return output.ToString(); 
    }
}