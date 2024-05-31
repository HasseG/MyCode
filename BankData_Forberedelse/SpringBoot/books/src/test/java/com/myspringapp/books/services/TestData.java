package com.myspringapp.books.services;

import com.myspringapp.books.domain.Book;
import com.myspringapp.books.domain.BookEntity;

public final class TestData {
    public TestData() {
    }

    public static Book testBook(){
        return Book.builder()
        .isbn("02345678")
        .author("Virginia Wolf")
        .title("The Waves")
        .build();
    }

    public static BookEntity testBookEntity(){
        return BookEntity.builder()
        .isbn("02345678")
        .author("Virginia Wolf")
        .title("The Waves")
        .build();
    }
    
}
