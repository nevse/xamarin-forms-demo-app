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
using System;
using System.Collections.Generic;
using DemoCenter.Forms.ViewModels;

namespace DemoCenter.Forms.Charts.ViewModels {
    public class DataItem {
        public DateTime Argument { get; }
        public double Value { get; }

        public DataItem(DateTime argument, double value) {
            Argument = argument;
            Value = value;
        }
    }

    public class LineChartsViewModel : ChartsPageViewModelBase {
        static readonly List<ChartItemInfoContainerBase> content = new List<ChartItemInfoContainerBase>() {
            new LineChartItemInfoContainer(
                viewModel: new LineChartViewModel(),
                type: LineType.Simple
            ),
            new LineChartItemInfoContainer(
                viewModel: new SplineChartViewModel(),
                type: LineType.Spline
            ),
            new LineChartItemInfoContainer(
                viewModel: new ScatterLineChartViewModel(),
                type: LineType.Scatter
            ),
            new LineChartItemInfoContainer(
                viewModel: new StepLineChartViewModel(),
                type: LineType.Step
            )
        };

        public override List<ChartItemInfoContainerBase> Content => content;
    }

    public class LineChartItemInfoContainer: ChartItemInfoContainerBase {
        public LineType LineType { get; set; }
        public LineChartItemInfoContainer(LineType type, ChartViewModelBase viewModel) {
            this.LineType = type;
            this.ChartModel = viewModel;
        }
    }
}
