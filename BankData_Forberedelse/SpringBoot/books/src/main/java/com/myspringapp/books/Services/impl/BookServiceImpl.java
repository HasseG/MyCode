package com.myspringapp.books.Services.impl;

import java.util.List;
import java.util.Optional;
import java.util.stream.Collector;
import java.util.stream.Collectors;

import org.springframework.stereotype.Service;

import com.myspringapp.books.Services.BookService;
import com.myspringapp.books.domain.Book;
import com.myspringapp.books.domain.BookEntity;
import com.myspringapp.books.repos.BookRepo;

@Service
public class BookServiceImpl implements BookService {

    private final BookRepo bookRepo;

    public BookServiceImpl(BookRepo bookRepo){
        this.bookRepo = bookRepo;
    }

    @Override
    public Book create(final Book book) {
        final BookEntity bookEntity = bookToBookEntity(book);
        final BookEntity savedBookEnt = bookRepo.save(bookEntity);
        return bookEntityToBook(savedBookEnt);

    }

    private BookEntity bookToBookEntity(Book book){
        return BookEntity.builder()
            .isbn(book.getIsbn())
            .author(book.getAuthor())
            .title(book.getTitle())
            .build();
    }

    private Book bookEntityToBook(BookEntity bookEntity){
        return Book.builder()
            .isbn(bookEntity.getIsbn())
            .author(bookEntity.getAuthor())
            .title(bookEntity.getTitle())
            .build();
    }

    @Override
    public Optional<Book> findById(String isbn) {
        final Optional<BookEntity> foundBook = bookRepo.findById(isbn);

        return foundBook.map(book -> bookEntityToBook(book));
    }

    @Override
    public List<Book> listBooks() {
        final List<BookEntity> foundBooks = bookRepo.findAll();
        return foundBooks.stream().map(book -> bookEntityToBook(book)).collect(Collectors.toList());
    }

    
    
}
