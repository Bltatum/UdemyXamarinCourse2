﻿using System;
using System.Collections.Generic;
using UdemyHelloWorld2.Models;
using Xamarin.Forms;

namespace UdemyHelloWorld2
{
	public partial class ContactsPage : ContentPage
	{
		async void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
			if (e.SelectedItem == null)
				return;

			var contact = e.SelectedItem as Contact;

			await Navigation.PushAsync(new ContactDetailPage(contact));
			listView.SelectedItem = null;
		}

		public ContactsPage()
		{
			InitializeComponent();

			listView.ItemsSource = new List<Contact> {
				new Contact { Name = "Mosh", ImageUrl = "http://lorempixel.com/100/100/people/1" },
				new Contact { Name = "John", ImageUrl = "http://lorempixel.com/100/100/people/2", Status = "Hey, let's talk!" }
			};
		}
	}
}
