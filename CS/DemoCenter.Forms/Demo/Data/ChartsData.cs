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
using DemoCenter.Forms.Models;
using DemoCenter.Forms.Views;

namespace DemoCenter.Forms.Data {
    public class ChartsData : IDemoData {
        readonly List<DemoItem> demoItems;

        public ChartsData() {
            this.demoItems = new List<DemoItem>() {
                new DemoItem() {
                    Title = "Axis Label Options",
                    Description = "Shows how to specify axis labels' rotation angle and arrange them in staggered order.",
                    Module = typeof(AxisLabelOptions),
                    Icon = "charts_axislabeloptions"
                },
                new DemoItem() {
                    Title = "Series Template",
                    Description = "Shows how to create autogenerated series from datasourse based on series template.",
                    Module = typeof(SeriesTemplate),
                    Icon = "charts_series_template"
                },
                new DemoItem() {
                    Title = "Custom Appearance",
                    Description = "Shows how to customize the appearance of series and other elements of the chart.",
                    Module = typeof(Colorizer),
                    Icon = "charts_custom_appearance"
                },
                new DemoItem() {
                    Title = "Spectrum Analysis",
                    Description = "Shows multiple charts that allow real-time frequency spectrum analysis.",
                    Module = typeof(SpectrumAnalyzer),
                    Icon = "charts_spectrumanalyzer",
                },
                new DemoItem() {
                    Title = "Logarithmic Scale",
                    Description = "Demonstrates a chart axis that uses the logarithmic scale to display numeric values.",
                    Module = typeof(LogarithmicScale),
                    Icon = "charts_headphones",
                },
                new DemoItem() {
                    Title = "Oscillator",
                    Description="Demonstrates how the chart performs full data updates in real time.",
                    Module = typeof(Oscillator),
                    Icon = "charts_oscillator",
                },
                new DemoItem() {
                    Title = "Financial" + Environment.NewLine + "Chart",
                    ControlsPageTitle = "Financial Chart",
                    Description="Displays Open-High-Low-Close stock price statistics as Candles Bars.",
                    Module = typeof(FinancialChart),
                    Icon = "charts_financialcharts"
                },
                new DemoItem() {
                    Title = "Real-Time Data Updates",
                    Description="Displays an auto-refreshed Line Chart bound to a frequently updated dataset.",
                    Module = typeof(RealTimeData),
                    Icon = "charts_realtimeupdates"
                },
                new DemoItem() {
                    Title = "Selection",
                    Description="Demonstrates support for series and point selection within a chart.",
                    Module = typeof(Selection),
                    Icon = "charts_selection"
                },
                new DemoItem() {
                    Title = "Multiple Axes",
                    Description="Demonstrates multiple axes within a single chart.",
                    Module = typeof(MultipleAxes),
                    Icon = "charts_multipleaxes"
                },
                new DemoItem() {
                    Title = "Large" + Environment.NewLine + "Dataset",
                    ControlsPageTitle = "Blazing Fast Native Rendering",
                    Description="Demonstrates the speed with which DevExpress Charts can render a large number of points.",
                    Module = typeof(LargeDataset),
                    Icon = "charts_largedataset"
                },
                new DemoItem() {
                    Title = "Bar" + Environment.NewLine + "Charts",
                    ControlsPageTitle = "Bar Charts",
                    Description="Demonstrates Stacked and Side-by-Side Bar series chart views.",
                    Module = typeof(BarCharts),
                    Icon = "charts_barcharts",
                },
                new DemoItem() {
                    Title = "Line" + Environment.NewLine + "Charts",
                    ControlsPageTitle = "Line Charts",
                    Description="Demonstrates use of Simple, Scatter, and Step Line chart series views.",
                    Module = typeof(LineCharts),
                    Icon = "charts_linecharts"
                },
                new DemoItem() {
                    Title = "Point & Bubble" + Environment.NewLine + "Charts",
                    ControlsPageTitle = "Point & Bubble Charts",
                    Description="Demonstrates the use of Point and Bubble chart series views.",
                    Module = typeof(PointsCharts),
                    Icon = "charts_pointandbublecharts"
                },
                new DemoItem() {
                    Title = "Area" + Environment.NewLine + "Charts",
                    ControlsPageTitle = "Area Charts",
                    Description="Demonstrates Simple, Stacked and Step Area chart series views.",
                    Module = typeof(AreaCharts),
                    Icon = "charts_areacharts"
                },
                new DemoItem() {
                    Title = "Pie & Donut" + Environment.NewLine + "Charts",
                    ControlsPageTitle = "Pie & Donut Charts",
                    Description="Demonstrates the use of multi-series Pie and Donut chart views.",
                    Module = typeof(PieCharts),
                    Icon = "charts_pieanddonutcharts",
                    ShowItemUnderline = false
                },
            };
        }
        public List<DemoItem> DemoItems => this.demoItems;
        public string Title { get { return "ChartView"; } }
    }
}
