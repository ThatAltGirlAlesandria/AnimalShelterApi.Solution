using AnimalShelter.Filters;

public interface IUriService
{
  public Uri GetPageUri(PaginationFilter filter, string route);
}