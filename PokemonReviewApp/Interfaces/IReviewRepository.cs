using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface IReviewRepository
    {
        ICollection<Review> GetReviews();
        Review GetReview(int reviewid);
        ICollection<Review> GetReviewsOfAPokemon(int pokeId);
        bool ReviewExist(int reviewid);
        bool CreateReview(Review review);
        bool UpdateReview(Review review);
        bool DeleteReview(Review review);
        bool DeleteReview(List<Review> reviews);
        bool Save();
    }
}
