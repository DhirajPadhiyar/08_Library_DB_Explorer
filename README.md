# Library Database Explorer

Day 8 Project of ASP.NET Core MVC Learning Journey.

## Concepts Covered

- SQL Basics
- Database Design
- Primary Key
- Foreign Key
- One-to-One Relationship
- One-to-Many Relationship
- Many-to-Many Relationship
- Junction Table

## Project Structure

### Book

- BookId
- BookName
- Author
- Category

### Member

- MemberId
- MemberName
- Email
- PhoneNumber

### IssuedBooks

- IssuedBooksId
- BookId
- MemberId
- IssueDate
- ReturnDate

## Relationship

Book (1) -----> IssuedBooks <----- (1) Member

IssuedBooks acts as a Bridge/Junction Table connecting Books and Members.

## Screenshots
<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/637e012f-a095-47dd-9b70-d2c2eb6bdbe0" />
<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/f90e42d0-9c60-478e-afe7-fb44f51301f2" />
<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/5130e85a-aa7d-4367-9475-45a0aaadea95" />

## Author

Dhiraj Padhiyar
