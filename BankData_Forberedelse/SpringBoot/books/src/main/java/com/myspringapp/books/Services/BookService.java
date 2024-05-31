package com.myspringapp.books.Services;

import java.util.List;
import java.util.Optional;
import com.myspringapp.books.domain.Book;

public interface BookService {

    Book create(Book book);
    Optional<Book> findById(String isbn);
    List<Book> listBooks();
}
