import { Component, OnInit } from '@angular/core';
import { Book } from '../books/book';
import { BOOKS } from '../books/mock-books-service';

@Component({
  //selector is app-books to tell where the component where our stuff is located and then has information regarding source
  //files for styling and component template
  selector: 'app-books',
  templateUrl: './books.component.html',
  styleUrls: ['./books.component.css']
})
export class BooksComponent implements OnInit {
  //Gets our mock component in mock-books-service
  books = BOOKS;
  
//below is part of the lab we hard-coded an instance to show our data in the web portal
/*   book: Book = {
    id: 1,
    title: 'Ready Player One',
    author: 'Ernest Cline'
  }
 */

  ngOnInit() {}
}
