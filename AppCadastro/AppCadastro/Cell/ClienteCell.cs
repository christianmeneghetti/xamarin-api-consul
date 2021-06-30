using ImageCircle.Forms.Plugin.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AppCadastro.Cell
{
    public class ClienteCell : ViewCell
    {
        public ClienteCell()
        {
            var IDCliente = new Label
            {
                HorizontalTextAlignment = TextAlignment.End,
                HorizontalOptions = LayoutOptions.Start,
                FontSize = 16,
                FontAttributes = FontAttributes.Bold,
            };
            IDCliente.SetBinding(Label.TextProperty, new Binding("10"));

            var Nome = new Label
            {
                FontSize = 24,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Start,
                Margin = 5,
            };
            Nome.SetBinding(Label.TextProperty, new Binding("Nome"));

            var Email = new Label
            {
                FontSize = 16,
                FontAttributes = FontAttributes.None,
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.Start,
                //Margin = 5,
            };
            Email.SetBinding(Label.TextProperty, new Binding("Email", stringFormat: " Email : {0}"));

            var Telefone = new Label
            {
                FontSize = 16,
                FontAttributes = FontAttributes.None,
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.Start,
                //Margin = 5,
            };
            Telefone.SetBinding(Label.TextProperty, new Binding("Telefone", stringFormat: " Telefone : {0}"));

            var Image = new CircleImage
            {
                BorderColor = Color.White,
                BorderThickness = 3,
                HeightRequest = 60,
                WidthRequest = 60,
                Aspect = Aspect.AspectFill,
                HorizontalOptions = LayoutOptions.Center,
                Source = "login-icon"
            };
            Image.SetBinding(Label.TextProperty, new Binding("Image"));

            var line1 = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children =
                {
                    Image,Nome
                },
            };

            var line2 = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children =
                {
                    Email,Telefone
                },
            };

            var line3 = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children =
                {
                    Image,Nome
                },
            };

            View = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                Children =
                {
                    line1, line2, line3
                },
            };
        }
    }
}
