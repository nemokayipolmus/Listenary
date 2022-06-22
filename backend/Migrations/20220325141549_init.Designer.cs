﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using listenary;

namespace listenary.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220325141549_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("listenary.Models.Album", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecordLabel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ArtistId");

                    b.ToTable("Albums");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArtistId = 1,
                            Image = "https://th.bing.com/th/id/OIP.QIo4l4lnGh-JcY5_x65DMgHaHa?pid=ImgDet&rs=1",
                            RecordLabel = "Aftermath",
                            Title = "DAMN."
                        },
                        new
                        {
                            Id = 2,
                            ArtistId = 1,
                            Image = "https://www.latercera.com/resizer/rIGTLbi8ie_DpkFAJRxkq5vI8W4=/900x600/smart/arc-anglerfish-arc2-prod-copesa.s3.amazonaws.com/public/L2EHWPGBSNA45DUPSXB2CHIYPU.jpg",
                            RecordLabel = "Aftermath",
                            Title = "To Pimp a Butterfly"
                        },
                        new
                        {
                            Id = 3,
                            ArtistId = 1,
                            Image = "https://th.bing.com/th/id/OIP.IPKkOHP67lCEhUFeeeyhYwHaHa?pid=ImgDet&rs=1",
                            RecordLabel = "Aftermath",
                            Title = "Good Kid, M.A.A.D. City"
                        },
                        new
                        {
                            Id = 4,
                            ArtistId = 1,
                            Image = "https://images.complex.com/complex/images/c_fill,g_center,h_300,q_auto,w_600/fl_lossy,pg_1/nmbw4qiwlch9sla2tcpz/kendrick-lamar-section-80-album-cover",
                            RecordLabel = "Top Dawg Entertainment",
                            Title = "Section.80"
                        },
                        new
                        {
                            Id = 5,
                            ArtistId = 1,
                            Image = "https://th.bing.com/th/id/R.48707a67ae5ea6e7d6704260536d477a?rik=DIWtz3R7GyygfQ&riu=http%3a%2f%2fimg.wennermedia.com%2fsocial%2frs-kendrick-lamar-untitled-unmastered-87205fdc-0504-4a57-858d-8d45151dcfb6.jpg&ehk=7tiuN1XFL9cfekR4Fs69ujMvkyuuZyaHIf1j3icB82g%3d&risl=&pid=ImgRaw&r=0",
                            RecordLabel = "Aftermath",
                            Title = "untitled unmastered."
                        },
                        new
                        {
                            Id = 6,
                            ArtistId = 1,
                            Image = "https://th.bing.com/th/id/OIP.orohBwmwTTKsR-SA_lRjcAHaEP?pid=ImgDet&rs=1",
                            RecordLabel = "Interscope",
                            Title = "Black Panther"
                        },
                        new
                        {
                            Id = 7,
                            ArtistId = 2,
                            Image = "https://i.pinimg.com/originals/38/e0/6e/38e06ed03db63c6d75338a5a76b3135b.png",
                            RecordLabel = "RCA Records",
                            Title = "Plastic Hearts"
                        },
                        new
                        {
                            Id = 8,
                            ArtistId = 2,
                            Image = "",
                            RecordLabel = "RecordLabel",
                            Title = "Album"
                        },
                        new
                        {
                            Id = 9,
                            ArtistId = 2,
                            Image = "",
                            RecordLabel = "RecordLabel",
                            Title = "Album"
                        },
                        new
                        {
                            Id = 10,
                            ArtistId = 2,
                            Image = "",
                            RecordLabel = "RecordLabel",
                            Title = "Album"
                        },
                        new
                        {
                            Id = 11,
                            ArtistId = 2,
                            Image = "",
                            RecordLabel = "RecordLabel",
                            Title = "Album"
                        },
                        new
                        {
                            Id = 12,
                            ArtistId = 2,
                            Image = "",
                            RecordLabel = "RecordLabel",
                            Title = "Album"
                        },
                        new
                        {
                            Id = 13,
                            ArtistId = 3,
                            Image = "https://m.media-amazon.com/images/I/81-blrK5yoL._SL1400_.jpg",
                            RecordLabel = "XO",
                            Title = "Album"
                        },
                        new
                        {
                            Id = 14,
                            ArtistId = 3,
                            Image = "",
                            RecordLabel = "RecordLabel",
                            Title = "Album"
                        },
                        new
                        {
                            Id = 15,
                            ArtistId = 3,
                            Image = "",
                            RecordLabel = "RecordLabel",
                            Title = "Album"
                        },
                        new
                        {
                            Id = 16,
                            ArtistId = 3,
                            Image = "",
                            RecordLabel = "RecordLabel",
                            Title = "Album"
                        },
                        new
                        {
                            Id = 17,
                            ArtistId = 3,
                            Image = "",
                            RecordLabel = "RecordLabel",
                            Title = "Album"
                        },
                        new
                        {
                            Id = 18,
                            ArtistId = 3,
                            Image = "",
                            RecordLabel = "RecordLabel",
                            Title = "Album"
                        },
                        new
                        {
                            Id = 19,
                            ArtistId = 4,
                            Image = "",
                            RecordLabel = "RecordLabel",
                            Title = "Album"
                        },
                        new
                        {
                            Id = 20,
                            ArtistId = 4,
                            Image = "",
                            RecordLabel = "RecordLabel",
                            Title = "Album"
                        },
                        new
                        {
                            Id = 21,
                            ArtistId = 4,
                            Image = "",
                            RecordLabel = "RecordLabel",
                            Title = "Album"
                        },
                        new
                        {
                            Id = 22,
                            ArtistId = 4,
                            Image = "",
                            RecordLabel = "RecordLabel",
                            Title = "Album"
                        },
                        new
                        {
                            Id = 23,
                            ArtistId = 4,
                            Image = "",
                            RecordLabel = "RecordLabel",
                            Title = "Album"
                        },
                        new
                        {
                            Id = 24,
                            ArtistId = 4,
                            Image = "",
                            RecordLabel = "RecordLabel",
                            Title = "Album"
                        },
                        new
                        {
                            Id = 25,
                            ArtistId = 5,
                            Image = "",
                            RecordLabel = "RecordLabel",
                            Title = "Album"
                        },
                        new
                        {
                            Id = 26,
                            ArtistId = 5,
                            Image = "",
                            RecordLabel = "RecordLabel",
                            Title = "Album"
                        },
                        new
                        {
                            Id = 27,
                            ArtistId = 5,
                            Image = "",
                            RecordLabel = "RecordLabel",
                            Title = "Album"
                        },
                        new
                        {
                            Id = 28,
                            ArtistId = 5,
                            Image = "",
                            RecordLabel = "RecordLabel",
                            Title = "Black Panther"
                        },
                        new
                        {
                            Id = 29,
                            ArtistId = 5,
                            Image = "",
                            RecordLabel = "RecordLabel",
                            Title = "Album"
                        },
                        new
                        {
                            Id = 30,
                            ArtistId = 5,
                            Image = "",
                            RecordLabel = "RecordLabel",
                            Title = "Album"
                        },
                        new
                        {
                            Id = 31,
                            ArtistId = 6,
                            Image = "",
                            RecordLabel = "RecordLabel",
                            Title = "Album"
                        },
                        new
                        {
                            Id = 32,
                            ArtistId = 6,
                            Image = "",
                            RecordLabel = "RecordLabel",
                            Title = "Album"
                        },
                        new
                        {
                            Id = 33,
                            ArtistId = 6,
                            Image = "",
                            RecordLabel = "RecordLabel",
                            Title = "Album"
                        },
                        new
                        {
                            Id = 34,
                            ArtistId = 6,
                            Image = "",
                            RecordLabel = "RecordLabel",
                            Title = "Album"
                        },
                        new
                        {
                            Id = 35,
                            ArtistId = 6,
                            Image = "",
                            RecordLabel = "RecordLabel",
                            Title = "Album"
                        },
                        new
                        {
                            Id = 36,
                            ArtistId = 6,
                            Image = "",
                            RecordLabel = "RecordLabel",
                            Title = "Album"
                        });
                });

            modelBuilder.Entity("listenary.Models.Artist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HeroImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Artists");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Bio = "Kendrick Lamar is an American rapper and lyricist. He is a critically and commercially acclaimed artist who started his musical journey as a teenager. He began his career in music by recording mix tapes under the pseudonym K-Dot. His first musical contract was signed at the age of sixteen with record label Top Dawg Entertainment.",
                            Genre = "Rap",
                            HeroImage = "/images/kendrick.jpg",
                            Name = "Kendrick Lamar"
                        },
                        new
                        {
                            Id = 2,
                            Bio = "Miley Ray Cyrus is an American singer, songwriter, actress, and television personality. Known for her distinctive raspy voice, her music incorporates elements of varied styles and genres, including pop, country pop, hip hop, experimental, and rock. She has attained the most US Billboard 200 top-five albums in the 21st century by a female artist, with a total of thirteen entries",
                            Genre = "Pop",
                            HeroImage = "/images/miley.jpg",
                            Name = "Miley Cyrus"
                        },
                        new
                        {
                            Id = 3,
                            Bio = "Abel Makkonen Tesfaye, professionally known as 'The Weeknd' is a Canadian singer born February 16, 1990 in Toronto. Best known for his performances in his latest album 'Starboy' (2016), and numerous other productions including 'Kissland' (2013), Beauty Behind the Madness (2015) which included the mega-hit; 'The Hills', and House of Balloons, Thursday and Echoes of Silence.",
                            Genre = "R&B",
                            HeroImage = "/images/theweekend.webp",
                            Name = "The Weekend"
                        },
                        new
                        {
                            Id = 4,
                            Bio = "Carrie Underwood was born on March 10, 1983 in Muskogee, Oklahoma, USA. She is known for Soul Surfer (2011), American Idol (2002) and The Chronicles of Narnia: The Voyage of the Dawn Treader (2010).",
                            Genre = "Country",
                            HeroImage = "https://townsquare.media/site/204/files/2019/11/Carrie-Underwood-Cries-Pretty.jpg?w=1200&h=0&zc=1&s=0&a=t&q=89",
                            Name = "Carrier Underwood"
                        },
                        new
                        {
                            Id = 5,
                            Bio = "Pink Floyd is a progressive rock band formed in 1965 in Cambridge & London, England, active since 1965 through 1983 & 1987 to present. Group's main members are Syd Barrett, Roger Waters, David Gilmour, Nick Mason, Rick Wright. ",
                            Genre = "Rock",
                            HeroImage = "https://th.bing.com/th/id/OIP.M5rS4qWkb6RfHK6LB5X_dAHaE8?pid=ImgDet&rs=1",
                            Name = "Pink Floyd"
                        },
                        new
                        {
                            Id = 6,
                            Bio = "Nicolás Jaar is a Chilean-American composer and recording artist based in New York. Among his notable works are the albums Space Is Only Noise, Sirens, and Cenizas. He has also released two albums as one half of his band Darkside and two further albums under the alias Against All Logic.",
                            Genre = "Electronic",
                            HeroImage = "https://vinilogarage.cl/wp-content/uploads/2021/03/UGZV2SHRX5DLFK5V6SQ5MKHGSY.jpg",
                            Name = "Nicolás Jaar"
                        });
                });

            modelBuilder.Entity("listenary.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AlbumId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReviewerName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AlbumId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AlbumId = 1,
                            Content = "My boyfriend fave album",
                            ReviewerName = "Miranda"
                        },
                        new
                        {
                            Id = 2,
                            AlbumId = 7,
                            Content = "I really wish she could do better",
                            ReviewerName = "user05079786"
                        },
                        new
                        {
                            Id = 3,
                            AlbumId = 13,
                            Content = "Love him!Praying for him every night<3",
                            ReviewerName = "TheWeekandJunkie"
                        },
                        new
                        {
                            Id = 4,
                            AlbumId = 19,
                            Content = "Not my type of music",
                            ReviewerName = "Sammy"
                        },
                        new
                        {
                            Id = 25,
                            AlbumId = 5,
                            Content = "Love it",
                            ReviewerName = "Landon"
                        },
                        new
                        {
                            Id = 31,
                            AlbumId = 6,
                            Content = "Listening in my car",
                            ReviewerName = "user005955857"
                        });
                });

            modelBuilder.Entity("listenary.Models.Song", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AlbumId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AlbumId");

                    b.ToTable("Songs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AlbumId = 1,
                            Title = "Loyalty ft. Rihanna"
                        },
                        new
                        {
                            Id = 2,
                            AlbumId = 1,
                            Title = "Lust"
                        },
                        new
                        {
                            Id = 3,
                            AlbumId = 1,
                            Title = "DNA"
                        },
                        new
                        {
                            Id = 4,
                            AlbumId = 1,
                            Title = "Feel"
                        },
                        new
                        {
                            Id = 5,
                            AlbumId = 1,
                            Title = "Blood"
                        },
                        new
                        {
                            Id = 6,
                            AlbumId = 2,
                            Title = "The Climb"
                        },
                        new
                        {
                            Id = 7,
                            AlbumId = 2,
                            Title = "We Can't Stop"
                        },
                        new
                        {
                            Id = 8,
                            AlbumId = 2,
                            Title = "7 Things"
                        },
                        new
                        {
                            Id = 9,
                            AlbumId = 2,
                            Title = "Start All Over"
                        },
                        new
                        {
                            Id = 10,
                            AlbumId = 2,
                            Title = "Alright"
                        },
                        new
                        {
                            Id = 11,
                            AlbumId = 2,
                            Title = "Prisoner (FEAT. DUA LIPA)"
                        },
                        new
                        {
                            Id = 12,
                            AlbumId = 2,
                            Title = "Angels Like You"
                        },
                        new
                        {
                            Id = 13,
                            AlbumId = 3,
                            Title = "The Morning"
                        },
                        new
                        {
                            Id = 14,
                            AlbumId = 3,
                            Title = "Wicked Games"
                        },
                        new
                        {
                            Id = 16,
                            AlbumId = 3,
                            Title = "Song"
                        },
                        new
                        {
                            Id = 17,
                            AlbumId = 3,
                            Title = "Song"
                        },
                        new
                        {
                            Id = 18,
                            AlbumId = 3,
                            Title = "Song"
                        },
                        new
                        {
                            Id = 19,
                            AlbumId = 3,
                            Title = "Song"
                        },
                        new
                        {
                            Id = 20,
                            AlbumId = 3,
                            Title = "Song"
                        },
                        new
                        {
                            Id = 21,
                            AlbumId = 3,
                            Title = "Song"
                        },
                        new
                        {
                            Id = 22,
                            AlbumId = 3,
                            Title = "Song"
                        });
                });

            modelBuilder.Entity("listenary.Models.Album", b =>
                {
                    b.HasOne("listenary.Models.Artist", "Artist")
                        .WithMany("Albums")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");
                });

            modelBuilder.Entity("listenary.Models.Review", b =>
                {
                    b.HasOne("listenary.Models.Album", "Album")
                        .WithMany("Reviews")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Album");
                });

            modelBuilder.Entity("listenary.Models.Song", b =>
                {
                    b.HasOne("listenary.Models.Album", "Album")
                        .WithMany("Songs")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Album");
                });

            modelBuilder.Entity("listenary.Models.Album", b =>
                {
                    b.Navigation("Reviews");

                    b.Navigation("Songs");
                });

            modelBuilder.Entity("listenary.Models.Artist", b =>
                {
                    b.Navigation("Albums");
                });
#pragma warning restore 612, 618
        }
    }
}
