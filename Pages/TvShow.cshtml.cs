namespace MovieMania.Pages;

public class TvShowModel : PageModel {

  public FetchTv fetchTv = new FetchTv();

  public async Task OnGet(){
      await fetchTv.GetTrending();
  }

  public async Task OnPostMovieSearch(string search) {
        await fetchTv.Search(search);
    }

    
    public async Task OnPostMovieDetails(string tvID) {
        await fetchTv.GetMovieDetails(tvID);
    }

    public async Task OnPostGetActor(string actorID){
        Response.Redirect("/Actor?id=" + actorID);

    }
} // class










