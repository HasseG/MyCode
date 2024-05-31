package com.myspringapp.books.repos;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import com.myspringapp.books.domain.BookEntity;


@Repository
public interface BookRepo extends JpaRepository<BookEntity, String>{
}
