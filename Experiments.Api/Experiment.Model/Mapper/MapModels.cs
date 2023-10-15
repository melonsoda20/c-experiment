namespace Experiment.Model.Mapper
{
    public static class MapModels
    {
        public static UserSample MapFrom(UserSampleRefit source) =>
            new UserSample()
            {
                Email = source.Email,
                Id = source.Id,
                Name = source.Name
            };
    }
}
