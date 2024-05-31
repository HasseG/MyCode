package com.myspringapp.books.controllers;

import java.util.Optional;
import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;

import com.myspringapp.books.Services.BookService;
import com.myspringapp.books.domain.Book;
import org.springframework.web.bind.annotation.GetMapping;


@Controller
public class BookController {
    private final BookService bookService;

    @Autowired
    public BookController(final BookService bookService) {
        this.bookService = bookService;
    }

    @PutMapping(path = "/books/{isbn}")
    public ResponseEntity<Book> createBook(@PathVariable final String isbn, @RequestBody final Book book){
        book.setIsbn(isbn);
        final Book savedbook = bookService.create(book);
        final ResponseEntity<Book> response = new ResponseEntity<Book>(savedbook, HttpStatus.CREATED);

        return response;
    }

    @GetMapping("/books/{isbn}")
    public ResponseEntity<Book> responseBook(@PathVariable String isbn){
        
        final Optional<Book> foundBook = bookService.findById(isbn);

        return foundBook.map(book -> new ResponseEntity<Book>(book, HttpStatus.OK))
        .orElse(new ResponseEntity<Book>(HttpStatus.NOT_FOUND));
    }

    @GetMapping("/books")
    public ResponseEntity<List<Book>> listBooks(){
        return new ResponseEntity<List<Book>>(bookService.listBooks(), HttpStatus.OK);
    }
    


}
