namespace FactSetAPI

open Microsoft.OData.Edm
open System.ComponentModel.DataAnnotations

module Models =
    module Etfdb =
        [<CLIMutable>]
        type Holidays = {
            [<Key>]
            Id: int;
            Holiday: string;
            Date: Date;
        }