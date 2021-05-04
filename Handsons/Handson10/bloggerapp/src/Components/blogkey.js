import React from 'react'
import '../Stylesheets/mystyle.css'
export function Blog(props) {
    const bookdet = (
      <ul>
        {props.books.map((book) =>
          <div key={book.id}>
          <h3>  {book.bname}</h3>
            <h4>{book.price}</h4>
          </div>
        )}
      </ul>
    );
    const content = props.posts.map((post) =>
      <div key={post.id}>
        <h1>{post.title}</h1>
        <h4>{post.Author}</h4>
        <p>{post.content}</p>
        
      </div>
    );
    const coursedet = props.courses.map((course) =>
    <div key={course.id}>
      <h1>{course.cname}</h1>
      <h4>{course.startdate}</h4>
     </div>
  );
    return (
      <div>
      <div>
      <div className="st2">
        <h1> Book Details</h1>
        {bookdet}
        </div>
        <div className="v1">
        <h1> Blog Details</h1>
        {content}
        </div>
        <div className="mystyle1">
          <h1> Course Details</h1>
        {coursedet}
      </div>
      </div>
      </div>
    );
  }
  export const courses =[
    {id:1001,cname:'Angular',startdate:'4/5/2021'},
    {id:1002,cname:'React',startdate:'6/3/20201'}
  ]; 
  export const posts = [
    {id: 1, title: 'React Learning', content: 'Welcome to learning React!',Author:'Stephen Biz'},
    {id: 2, title: 'Installation', content: 'You can install React from npm.',Author:'Schewzdenier'}
  ];
export const books=[
  {id:101,bname:'Master React',price:670},
  {id:102,bname:'Deep Dive into Angular 11 ',price:800},
  {id:103,bname:'Mongo Essentials',price:450},
];
 