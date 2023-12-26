using Mapper.Abstract;

namespace Mapper.Concrete
{
    public class GenericMapExtensions<T> : IGenericMapExtensions<T>
    {
        /// <summary>
        /// Usage: Give the objfrom object in the db a singleton, i.e. 'x=>' (lambda)
        /// Note: It can also be used as DTO to Entity. Note: It can also be used as DTO to Entity.
        /// </summary>
        /// <typeparam name="T">Your response object (DTO)</typeparam>
        /// <param name="objfrom">Your entity or your dto</param>
        /// <param name="objto">Your entity or your dto</param>
        /// <returns>T object -> objto parameter</returns>
        public T Map(object objfrom, T objto)
        {
            var ToProperties = objto.GetType().GetProperties();
            var FromProperties = objfrom.GetType().GetProperties();

            ToProperties.ToList().ForEach(o =>
            {
                var fromp = FromProperties.FirstOrDefault(x => x.Name == o.Name && x.PropertyType == o.PropertyType);
                if (fromp != null)
                {
                    o.SetValue(objto, fromp.GetValue(objfrom));
                }
            });

            return objto;
        }

        /// <summary>
        /// Usage: Give the objfrom object in the db a singleton, i.e. 'x=>' (lambda)
        /// Note: It can also be used as DTO to Entity. Note: It can also be used as DTO to Entity.
        /// </summary>
        /// <typeparam name="T">Your response object (DTO)</typeparam>
        /// <param name="objfrom">Your entity or your dto</param>
        /// <param name="objto">Your entity or your dto</param>
        /// <returns>T object -> objto parameter</returns>
        public async ValueTask<T> MapAsync(object objfrom, T objto)
        {
            var ToProperties = objto.GetType().GetProperties();
            var FromProperties = objfrom.GetType().GetProperties();

            ToProperties.ToList().ForEach(o =>
            {
                var fromp = FromProperties.FirstOrDefault(x => x.Name == o.Name && x.PropertyType == o.PropertyType);
                if (fromp != null)
                {
                    o.SetValue(objto, fromp.GetValue(objfrom));
                }
            });

            return objto;
        }
    }
}