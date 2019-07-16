namespace FactSetAPI.Controllers.Etfdb

open FactSetAPI.Models.Etfdb
open Microsoft.AspNet.OData
open Microsoft.OData.Edm
open System.Globalization
open System.Linq

    [<EnableQuery>]
    type HolidaysController() = 
        inherit ODataController()
        let holidays = [
            {Id = 57; Holiday = "New Years Day"; Date = Date.Parse("2019-01-01", CultureInfo.InvariantCulture)};
            {Id = 58; Holiday = "Martin Luther King; Jr. Day"; Date = Date.Parse("2019-01-21", CultureInfo.InvariantCulture)};
            {Id = 59; Holiday = "Washington's Birthday"; Date = Date.Parse("2019-02-18", CultureInfo.InvariantCulture)};
            {Id = 60; Holiday = "Good Friday"; Date = Date.Parse("2019-04-19", CultureInfo.InvariantCulture)};
            {Id = 61; Holiday = "Memorial Day"; Date = Date.Parse("2019-05-27", CultureInfo.InvariantCulture)};
            {Id = 62; Holiday = "Independence Day"; Date = Date.Parse("2019-07-04", CultureInfo.InvariantCulture)};
            {Id = 63; Holiday = "Labor Day"; Date = Date.Parse("2019-09-02", CultureInfo.InvariantCulture)};
            {Id = 64; Holiday = "Thanksgiving Day"; Date = Date.Parse("2019-11-28", CultureInfo.InvariantCulture)};
            {Id = 65; Holiday = "Christmas"; Date = Date.Parse("2019-12-25", CultureInfo.InvariantCulture)};
            {Id = 66; Holiday = "New Years Day"; Date = Date.Parse("2020-01-01", CultureInfo.InvariantCulture)};
            {Id = 67; Holiday = "Martin Luther King; Jr. Day"; Date = Date.Parse("2020-01-20", CultureInfo.InvariantCulture)};
            {Id = 68; Holiday = "Washington's Birthday"; Date = Date.Parse("2020-02-17", CultureInfo.InvariantCulture)};
            {Id = 69; Holiday = "Good Friday"; Date = Date.Parse("2020-04-10", CultureInfo.InvariantCulture)};
            {Id = 70; Holiday = "Memorial Day"; Date = Date.Parse("2020-05-25", CultureInfo.InvariantCulture)};
            {Id = 71; Holiday = "Independence Day"; Date = Date.Parse("2020-07-03", CultureInfo.InvariantCulture)};
            {Id = 72; Holiday = "Labor Day"; Date = Date.Parse("2020-09-07", CultureInfo.InvariantCulture)};
            {Id = 73; Holiday = "Thanksgiving Day"; Date = Date.Parse("2020-11-26", CultureInfo.InvariantCulture)};
            {Id = 74; Holiday = "Christmas"; Date = Date.Parse("2020-12-25", CultureInfo.InvariantCulture)}
        ]
        member __.Get() = holidays.AsQueryable()