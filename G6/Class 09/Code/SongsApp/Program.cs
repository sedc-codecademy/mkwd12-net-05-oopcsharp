using SongsApp.Domain.Models;
using SongsApp.Domain.Enums;

Person person = new Person("Petko", "Petkovski", 25, GenreEnum.Rock);
person.GetFavSongs();

//person.FavouriteSongs is our list of songs and we use Add() to add new songs to that list
person.FavouriteSongs.Add(new Song("Song1", 3.20, GenreEnum.Rock));
person.FavouriteSongs.Add(new Song("Song2", 2.70, GenreEnum.Rock));

person.GetFavSongs();