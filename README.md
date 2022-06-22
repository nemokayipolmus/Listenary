# Listenary
CENG 423 Project
Ahmet Alper Dönmez - 17050111025
Ceyda Alper - 18050111013
Enver Köroğlu - 17050111003

## Requirements
We are going to create an API using ASP.Net Entity Framework that will handle our DB and interactions with it.
- Create a RESTful API with ASP.Net
- Endpoints for the following:
   - All CRUD operations for artists
      - Create endpoint
      - Read endpoint
      - Update endpoint
      - Delete endpoint
   - All CRUD operations for albums
      - Create endpoint
      - Read endpoint
      - Update endpoint
      - Delete endpoint
- A database service layer for retrieving and storing artists, albums, and songs from the database and interacting with the controllers.

Our user should be able to:
- access albums from the artist that made them.
- access songs from the album the song is on.
- access reviews from the album the review is on.
- interact with input fields for each entity


## Stretch Tasks
Implement all CRUD operations for songs
- Create endpoint
- Read endpoint
- Update endpoint
- Delete endpoint
Implement all CRUD operations for reviews
- Create endpoint
- Read endpoint
- Update endpoint
- Delete endpoint


Entities
- artist
   - id
   - name
   - image
   - albums
   - any other pertinent info. which could include:
      - age
      - record label
      - hometown
- album
   - id
   - title
   - image
   - artist
   - songs (either as a string to be separated, or see below)
   - reviews
   - record label
- song
   - id
   - title
   - album
- review
   - reviewer name
   - content
   - album
