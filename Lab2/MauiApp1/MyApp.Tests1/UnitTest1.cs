using MauiApp1.ViewModels;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.Maui.Devices;
using System.Windows.Input;
using Microsoft.Maui.Controls;
using System.Net.Http;
using System.Text.Json;
//using Xunit;

namespace MyApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var viewModel = new MainViewModel();
            Assert.Equal("Welcome to.NET MAUI", viewModel.Title);
        }
    }
}