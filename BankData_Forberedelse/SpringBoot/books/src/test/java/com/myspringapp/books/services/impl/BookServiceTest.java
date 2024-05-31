package com.myspringapp.books.services.impl;

import static org.junit.jupiter.api.Assertions.assertEquals;
import static org.mockito.ArgumentMatchers.eq;
import static org.mockito.Mockito.when;

import static com.myspringapp.books.services.TestData.testBook;
import static com.myspringapp.books.services.TestData.testBookEntity;

import org.junit.jupiter.api.Test;
import org.junit.jupiter.api.extension.ExtendWith;
import org.mockito.InjectMocks;
import org.mockito.Mock;
import org.mockito.junit.jupiter.MockitoExtension;

import com.myspringapp.books.Services.impl.BookServiceImpl;
import com.myspringapp.books.domain.Book;
import com.myspringapp.books.domain.BookEntity;
import com.myspringapp.books.repos.BookRepo;

@ExtendWith(MockitoExtension.class)
public class BookServiceTest {

    @Mock
    private BookRepo bookRepo;

    @InjectMocks
    private BookServiceImpl underTest;

    @Test
    public void testThatBookIsSaved(){
       
        final Book book = testBook();
        final BookEntity bookEntity = testBookEntity();

        when(bookRepo.save(eq(bookEntity))).thenReturn(bookEntity);

        final Book result = underTest.create(book);

        assertEquals(book, result);
    }

}
