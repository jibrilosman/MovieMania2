namespace MovieMania.Pages;

public class ActorModel : PageModel{


    public Fetch fetch = new Fetch();
    public int age = 0;



    public  async Task OnGet(string id){
        await fetch.ActorDetails(id);

        string birthDate = fetch.actor.birthday;

            if(fetch.actor.birthday != null){

            string birthYear = birthDate.Substring(0, 4);
            age = DateTime.Now.Year - Convert.ToUInt16(birthYear);
            }
        
     }  
} //class