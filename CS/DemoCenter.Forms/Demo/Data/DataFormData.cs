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
using System.Collections.Generic;
using DemoCenter.Forms.Models;
using DemoCenter.Forms.Views;

namespace DemoCenter.Forms.Data {
    public class DataFormData : IDemoData {
        readonly List<DemoItem> demoItems;

        public DataFormData() {
            this.demoItems = new List<DemoItem>() {
                new DemoItem() {
                    DemoItemStatus = DemoItemStatus.Updated,
                    Title = "Delivery Form",
                    Description = "A delivery form with a filled box style.",
                    Module = typeof(DeliveryFormView),
                    Icon = "editors_dataforms"
                },
                new DemoItem() {
                    Title = "Account Form",
                    Description = "An account form with an outlined box style.",
                    Module = typeof(DataFormAccountFormView),
                    Icon = "editors_accountform"
                }
                ,
                new DemoItem() {
                    Title = "Employee Form",
                    Description = "An employee form with an outlined box style.",
                    Module = typeof(EmployeeFormView),
                    Icon = "editors_employeeform",
                    ShowItemUnderline = false
                }
            };
        }

        public List<DemoItem> DemoItems => this.demoItems;
        public string Title => "Editors";
    }
}
