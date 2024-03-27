# Library System Software
## About
An A-Level NEA (C#) project. The project is a Library Bespoke Software aim towards creating an online platform for library members to take out and return book loans, as well as tracking/managing the data of books and members assoiated with the library. The software is aimed to work on a client server over a LAN network.

## Features
This project utilised an SQL server storing a collection of books stock
and book information, library members and staff (login and personal) information and book
loan records. The SQL server spanned over a local network with a static IP which allowed the
software to work on any computer inside the LAN network. An asynchronous TCP server was built
to file transfer images from the server to the software's host computer. This was to overcome
the limitations of the free SQL express server used. The software used WPF to create the
UI interfaces for the application. This includes a registration and sign in interface (for library
staff and members), an interface for withdrawing or returning books from the library (for
members) and an interface for the view/adjustment of data stored in the SQL database (for
staff). The system had an automated emailing system to email clients (registered to the
system) about near/overdue book loans or confirmation of any new book loans taken by a
member.
## Built With
 - UI interface: WPF (using XML)
 - Back End: C#
 - Database: [Microsoft SQL 2019 Express](https://www.microsoft.com/en-gb/download/details.aspx?id=101064) (using SQL)


## Requirements
- The project software is exclusive to `Windows` OS.
- The project also requires Microsoft SQL Express Server using a static IP, which is required for the application database connection.
- The TCP server for image transfer also requires a static IP (ideally on the same device and IP as the SQL server).
