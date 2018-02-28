import { Component, OnInit } from '@angular/core';
import { IBook } from '../books/book';
import { BooksService } from '../books/books.service';

@Component({
  //selector is app-books to tell where the component where our stuff is located and then has information regarding source
  //files for styling and component template
  selector: 'app-books',
  templateUrl: './books.component.html',
  styleUrls: ['./books.component.css']
})
export class BooksComponent implements OnInit {
  //loabs books from the BooksService during initialization
  books: IBook[] = [];
  selectedBook: IBook;

  constructor(private _booksService: BooksService) {}

  ngOnInit() {
    this._booksService.getBooks()
      .subscribe(books => {
        this.books = books;
      },
        error => console.log(error)
      );
  }

  //Represents our event binding
  onSelect(book: IBook): void {
    this.selectedBook = book;
  }
}
