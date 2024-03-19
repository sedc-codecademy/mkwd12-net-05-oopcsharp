using QinshiftAcademy.SongsApplication.Domain.Enums;
using QinshiftAcademy.SongsApplication.Domain.Models;

Person person = new Person("John", "Johnsky", 40, Genre.Classical);
Song song = new Song("Example song", 3.50, Genre.Classical);

person.AddSong(song);