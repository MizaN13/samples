/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Application
{
    public static partial class CityUtils
    {
    }
}

************************************************/

using TheSharpFactory.Data.Entity.WorldWideImporters.Application;
using TheSharpFactory.Data.Query;

namespace TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Application
{

    /// <summary>
    /// This class is a utility class for a TheSharpFactory.Data.Entity.WorldWideImporters.Application.City.
    /// </summary>
    public static partial class CityUtils
    {
        /// <summary>
        /// Compare 2 Entities for changes. NavProperties are NOT taken into account. For NavProperties use the corresponding utils for those Entities
        /// </summary>
        /// <param name="one">Entity One.</param>
        /// <param name="two">Entity Two.</param>
        /// <returns>True if there is changes. False if no changes found.</returns>
        public static bool HasChanges(City one, City two)
        {
            // this method returns true if differences are found between the 2 entities.
            #region Detect Changes
            if(one.CityID != two.CityID)
                return true;
            if(string.CompareOrdinal(one.CityName, two.CityName) != 0)
                return true;
            if(one.StateProvinceID != two.StateProvinceID)
                return true;
            if(one.Location != two.Location)
                return true;
            if(one.LatestRecordedPopulation != two.LatestRecordedPopulation)
                return true;
            if(one.LastEditedBy != two.LastEditedBy)
                return true;
            if(one.ValidFrom != two.ValidFrom)
                return true;
            if(one.ValidTo != two.ValidTo)
                return true;
            #endregion
            return false;
        }
        /// <summary>
        /// Merge all values from one Entity into another one.
        /// </summary>
        /// <param name="source">Source Entity. Will be copied to the target.</param>
        /// <param name="target">Target Entity. Will receive the values from the source.</param>
        /// <returns>void.</returns>
        public static void Merge(City source, City target)
        {
            // this method merges 2 Entities.
            #region Merge Values
            target.CityID = source.CityID;
            target.CityName = source.CityName;
            target.StateProvinceID = source.StateProvinceID;
            target.Location = source.Location;
            target.LatestRecordedPopulation = source.LatestRecordedPopulation;
            target.LastEditedBy = source.LastEditedBy;
            target.ValidFrom = source.ValidFrom;
            target.ValidTo = source.ValidTo;
            #endregion
        }
        /// <summary>
        /// Get a list of QueryFilter that represent changed fields.
        /// </summary>
        /// <param name="original">Original Entity. The unchanged entity.</param>
        /// <param name="changed">Changed Entity. The entity holding the changed fields.</param>
        /// <returns>QueryFilters of CityProperty</returns>
        public static QueryFilters<CityProperty> GetChanges(City original, City changed)
        {
            // this method returns a list of changes.
            var changes = new QueryFilters<CityProperty>(8);
            #region Detect Changes
            if(original.CityID != changed.CityID)
                changes.Add(QueryFilter.New(CityProperty.CityID, FilterConditions.Equals, changed.CityID));
            if(string.CompareOrdinal(original.CityName, changed.CityName) != 0)
                changes.Add(QueryFilter.New(CityProperty.CityName, FilterConditions.Equals, changed.CityName));
            if(original.StateProvinceID != changed.StateProvinceID)
                changes.Add(QueryFilter.New(CityProperty.StateProvinceID, FilterConditions.Equals, changed.StateProvinceID));
            if(original.Location != changed.Location)
                changes.Add(QueryFilter.New(CityProperty.Location, FilterConditions.Equals, changed.Location));
            if(original.LatestRecordedPopulation != changed.LatestRecordedPopulation)
                changes.Add(QueryFilter.New(CityProperty.LatestRecordedPopulation, FilterConditions.Equals, changed.LatestRecordedPopulation));
            if(original.LastEditedBy != changed.LastEditedBy)
                changes.Add(QueryFilter.New(CityProperty.LastEditedBy, FilterConditions.Equals, changed.LastEditedBy));
            if(original.ValidFrom != changed.ValidFrom)
                changes.Add(QueryFilter.New(CityProperty.ValidFrom, FilterConditions.Equals, changed.ValidFrom));
            if(original.ValidTo != changed.ValidTo)
                changes.Add(QueryFilter.New(CityProperty.ValidTo, FilterConditions.Equals, changed.ValidTo));
            #endregion
            return changes.Count > 0 ? changes : null;
        }
    }
}
