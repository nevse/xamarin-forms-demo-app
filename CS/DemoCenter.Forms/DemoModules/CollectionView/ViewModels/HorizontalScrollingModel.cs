/*
               Copyright (c) 2015-2022 Developer Express Inc.
{*******************************************************************}
{                                                                   }
{       Developer Express Mobile UI for Xamarin.Forms               }
{                                                                   }
{                                                                   }
{       Copyright (c) 2015-2022 Developer Express Inc.              }
{       ALL RIGHTS RESERVED                                         }
{                                                                   }
{   The entire contents of this file is protected by U.S. and       }
{   International Copyright Laws. Unauthorized reproduction,        }
{   reverse-engineering, and distribution of all or any portion of  }
{   the code contained in this file is strictly prohibited and may  }
{   result in severe civil and criminal penalties and will be       }
{   prosecuted to the maximum extent possible under the law.        }
{                                                                   }
{   RESTRICTIONS                                                    }
{                                                                   }
{   THIS SOURCE CODE AND ALL RESULTING INTERMEDIATE FILES           }
{   ARE CONFIDENTIAL AND PROPRIETARY TRADE                          }
{   SECRETS OF DEVELOPER EXPRESS INC. THE REGISTERED DEVELOPER IS   }
{   LICENSED TO DISTRIBUTE THE PRODUCT AND ALL ACCOMPANYING         }
{   CONTROLS AS PART OF AN EXECUTABLE PROGRAM ONLY.                 }
{                                                                   }
{   THE SOURCE CODE CONTAINED WITHIN THIS FILE AND ALL RELATED      }
{   FILES OR ANY PORTION OF ITS CONTENTS SHALL AT NO TIME BE        }
{   COPIED, TRANSFERRED, SOLD, DISTRIBUTED, OR OTHERWISE MADE       }
{   AVAILABLE TO OTHER INDIVIDUALS WITHOUT EXPRESS WRITTEN CONSENT  }
{   AND PERMISSION FROM DEVELOPER EXPRESS INC.                      }
{                                                                   }
{   CONSULT THE END USER LICENSE AGREEMENT FOR INFORMATION ON       }
{   ADDITIONAL RESTRICTIONS.                                        }
{                                                                   }
{*******************************************************************}
*/
﻿using System;
using System.Collections.Generic;
using DemoCenter.Forms.DemoModules.CollectionView.Data;

namespace DemoCenter.Forms.ViewModels {
    public class HorizontalScrollingModel : NotificationObject {
        readonly List<HouseSales> itemSource;
        public IList<HouseSales> ItemSource => this.itemSource;

        public HorizontalScrollingModel() {
            itemSource = new List<HouseSales>() {
                new HouseSales() { Id = 1, Address = "652 Avonwick Gate, Toronto, ON", Price = 780000, ImageName = "1", Description = "Dishwasher, Disposal, Separate laundry room, 3/4 bath downstairs, Formal dining room, Downstairs family room, Separate family room, Breakfast Bar/Counter, Breakfast nook (eating area), Granite countertops in kitchen, Hardwood flooring in kitchen, Kitchen island, Solid surface countertops in kitchen, Entry foyer, Front living room, Ceiling fan in master bedroom, Master bedroom separate from other, Mirrored door closet in master bedroom, 2nd bedroom: 11x13, 3rd bedroom: 11x14, 4th Bedroom: 18x13, Alarm system owned, Built-in microwave, Carpet, Ceiling fan(s), Convection oven, Double built-in gas ovens, Gas cooktop, Gas stove, Marble/Stone floors" },
                new HouseSales() { Id = 2, Address = "82649 Topeka St, Riverbank, CA", Price = 1750000, ImageName = "2", Description = "Dishwasher, Disposal, Separate laundry room, Full bath downstairs, Formal dining room, Downstairs family room, Separate family room, Breakfast Bar/Counter, Breakfast nook (eating area), Granite countertops in kitchen, Kitchen custom cabinets, Kitchen island, Pantry, Walk-in pantry, Entry foyer, Formal living room, Rear living room, Vaulted ceiling in living room, Balcony in master bedroom, Master bedroom separate from other, Master bedroom upstairs, Sitting room in master bedroom, Walk-in closet in master bedroom, 2nd bedroom: 13X20, 3rd bedroom: 13X17, 4th Bedroom: 13X18, 5th Bedroom: 14X16, Alarm system owned, Blinds, Built-in electric oven, Built-in microwave, Carpet, Ceiling fan(s), Gas cooktop, Intercom system, Marble/Stone floors, Water conditioner owned, Water filtering system, Window Coverings Throughout" },
                new HouseSales() { Id = 3, Address = "328 S Kerema Ave, Milford, CT", Price = 350000, ImageName = "3", Description = "Dishwasher, Disposal, Refrigerator, Separate laundry room, Washer/Dryer on 2nd floor, Full bath downstairs, Formal dining room, Downstairs family room, Separate family room, Wet bar in family room, Breakfast nook (eating area), Garden window in kitchen, Granite countertops in kitchen, Kitchen island, Marble/Stone flooring in kitchen, Pantry, Formal living room, Front living room, Master bedroom separate from other, Master bedroom upstairs, Sitting room in master bedroom, Walk-in closet in master bedroom, 2nd bedroom: 16x12, 3rd bedroom: 13x16, 4th Bedroom: 18x12, Alarm system owned, Built-in microwave, Carpet, Ceiling fan(s), Double built-in electric ovens, Gas cooktop, Marble/Stone floors" },
                new HouseSales() { Id = 4, Address = "5119 Beryl Dr, San Antonio, TX", Price = 455000, ImageName = "4", Description = "Dishwasher, Disposal, Refrigerator, Separate laundry room, Full bath downstairs, Living/Dining room combo, Separate family room, Breakfast Bar/Counter, Breakfast nook (eating area), Granite countertops in kitchen, Kitchen custom cabinets, Kitchen island, Recessed lighting in kitchen, Tile flooring in kitchen, Walk-in pantry, Formal living room, Front living room, Ceiling fan in master bedroom, Master bedroom downstairs, Walk-in closet in master bedroom, 2nd bedroom: 15x13, 3rd bedroom: 12x12, 4th Bedroom: 14x12, Alarm system owned, Blinds, Built-in microwave, Carpet, Ceiling fan(s), Central vacuum, Convection oven, Double built-in electric ovens, Electric cooktop, Intercom system, Tile floors" },
                new HouseSales() { Id = 5, Address = "61207 16th St N, Moorhead, MN", Price = 1700000, ImageName = "5", Description = "Dishwasher, Disposal, Separate laundry room, Washer/Dryer on 1st floor, Full bath downstairs, Formal dining room, Downstairs family room, Separate family room, Breakfast Bar/Counter, Breakfast nook (eating area), Granite countertops in kitchen, Kitchen custom cabinets, Kitchen island, Formal living room, Rear living room, Sunken living room, Vaulted ceiling in living room, Balcony in master bedroom, Ceiling fan in master bedroom, Master bedroom separate from other, Master bedroom upstairs, Walk-in closet in master bedroom, 2nd bedroom: 16X17, 3rd bedroom: 14X16, 4th Bedroom: 13X13, 5th Bedroom: 12X12, Blinds, Built-in microwave, Carpet, Ceiling fan(s), Central vacuum, Double built-in electric ovens, Gas cooktop, Marble/Stone floors, Pot shelves, Water conditioner owned, Water filtering system, Window Coverings Throughout" },
                new HouseSales() { Id = 6, Address = "8512 Tanglewood Cir, Reform, AL", Price = 250000, ImageName = "6", Description = "Dishwasher, Disposal, Refrigerator, Separate laundry room, Full bath downstairs, Formal dining room, Built-in bookcases in family room, Downstairs family room, Separate family room, Breakfast Bar/Counter, Breakfast nook (eating area), Granite countertops in kitchen, Kitchen custom cabinets, Kitchen island, Marble/Stone flooring in kitchen, Pantry, Formal living room, Front living room, Ceiling fan in master bedroom, Master bedroom downstairs, Master bedroom separate from other, Sitting room in master bedroom, Walk-in closet in master bedroom, 2nd bedroom: 11X15, 3rd bedroom: 11X14, Alarm system owned, Blinds, Built-in microwave, Carpet, Ceiling fan(s), Double built-in electric ovens, Drapes, Electric cooktop, Marble/Stone floors, Window Coverings Throughout, Wine refrigerator" },
                new HouseSales() { Id = 7, Address = "7121 Bailey St, Worcester, MA", Price = 555000, ImageName = "7", Description = "Dishwasher, Disposal, Refrigerator, Separate laundry room, Washer/Dryer on 1st floor, Full bath downstairs, Formal dining room, Downstairs family room, Separate family room, Breakfast Bar/Counter, Breakfast nook (eating area), Kitchen island, Recessed lighting in kitchen, Tile countertops in kitchen, Walk-in pantry, Entry foyer, Formal living room, Front living room, Dressing room in master bedroom, Master bedroom separate from other, Master bedroom upstairs, Walk-in closet in master bedroom, 2nd bedroom: 14x16, 3rd bedroom: 12x13, 4th Bedroom: 13x14, Carpet, Double built-in electric ovens, Drywall, Gas cooktop, Manmade wood or laminate floors, Marble/Stone floors, Water conditioner loope" },
                new HouseSales() { Id = 8, Address = "620201 Plymouth Rd, Detroit, MI", Price = 610000, ImageName = "8", Description = "Dishwasher, Disposal, Refrigerator, Separate laundry room, Full bath downstairs, Formal dining room, 2+ family rooms, Separate family room, Breakfast nook (eating area), Granite countertops in kitchen, Kitchen custom cabinets, Kitchen island, Walk-in pantry, Entry foyer, Formal living room, Rear living room, Vaulted ceiling in living room, Ceiling fan in master bedroom, Master bedroom downstairs, Walk-in closet in master bedroom, 2nd bedroom: 12x15, 3rd bedroom: 12x15, 4th Bedroom: 12x15, Blinds, Built-in microwave, Carpet, Ceiling fan(s), Electric cooktop, Shutters, Skylight(s), Water conditioner owned, Water filtering system, Window coverings partial" },
                new HouseSales() { Id = 9, Address = "1198 Theresa Cir, Whitinsville, MA", Price = 320000, ImageName = "9", Description = "Dishwasher, Disposal, Refrigerator, Separate laundry room, Washer/Dryer on 1st floor, 1/2 bath downstairs, Formal dining room, 2+ family rooms, Built-in bookcases in family room, Breakfast Bar/Counter, Granite countertops in kitchen, Kitchen island, Tile flooring in kitchen, Walk-in pantry, Entry foyer, Formal living room, Built-in bookcases in master bedroom, Built-in entertainment center in master bedroom, Ceiling fan in master bedroom, Dressing room in master bedroom, Walk-in closet in master bedroom, 2nd bedroom: 13x12, 3rd bedroom: 12x12, 4th Bedroom: 13x12, Alarm system rented, Blinds, Built-in microwave, Carpet, Ceiling fan(s), Double built-in gas ovens, Tile floors, Window Coverings Throughout" },
            };
        }
    }
}
