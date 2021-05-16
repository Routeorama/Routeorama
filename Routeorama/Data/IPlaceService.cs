using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Routeorama.Models;

namespace Routeorama.Data
{
    public interface IPlaceService
    {
        Task<Place> CreateNewPlace(Place place);
        void SetPlaceName(string placeName);
        Task<Place> FetchPlaceData();
        Task<Place> FetchPlaceData(string name);
        Task<List<Place>> GetPlacesInBounds(List<double> bounds);
        Task FollowPlace(int placeId, int userId, bool action);
        Task<bool> GetFollowState(int placeId, int userId);
    }
}