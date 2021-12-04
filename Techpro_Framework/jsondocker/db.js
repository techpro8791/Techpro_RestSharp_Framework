/**
 * This is a the main database file. It's meant to be mounted over.
 */
module.exports = () => ({
  posts: [
    {
      id: 1,
      title: 'json-server',
      author: 'Karthik KK'
    },
    {
      id: 2,
      title: 'json-server',
      author: 'Karthik KK'
    },
    {
      title: 'RestAssured course',
      author: 'Brandon',
      id: 3
    },
    {
      title: 'RestAssured course',
      author: 'Karthik KK',
      id: 4
    },
    {
      title: 'RestAssured course',
      author: 'Karthik KK',
      id: 5
    },
    {
      title: 'RestAssured course',
      author: 'ExecuteAutomation',
      id: 6
    },
    {
      title: 'RestAssured course',
      author: 'Karthik KK',
      id: 7
    },
    {
      title: 'RestAssured course',
      author: 'Karthik KK',
      id: 8
    },
    {
      title: 'RestAssured course',
      author: 'Karthik KK',
      id: 9
    }
  ],
  comments: [
    {
      id: 1,
      body: 'some comment',
      postId: 1
    }
  ],
  profile: [
    {
      name: 'Sams',
      profileId: 1,
      postId: '2'
    },
    {
      name: 'Karthik',
      profileId: 2,
      postId: '1'
    },
    {
      name: 'Jonathan',
      profileId: 3,
      postId: '3'
    },
    {
      name: 'Brandon',
      profileId: 4,
      postId: '6'
    }
  ],
  complexdata: {
    page: 2,
    per_page: 3,
    total: 12,
    total_pages: 4,
    data: [
      {
        id: 4,
        email: 'eve.holt@reqres.in',
        first_name: 'Eve',
        last_name: 'Holt',
        avatar: 'https://s3.amazonaws.com/uifaces/faces/twitter/marcoramires/128.jpg'
      },
      {
        id: 5,
        email: 'charles.morris@reqres.in',
        first_name: 'Charles',
        last_name: 'Morris',
        avatar: 'https://s3.amazonaws.com/uifaces/faces/twitter/stephenmoon/128.jpg'
      },
      {
        id: 6,
        email: 'tracey.ramos@reqres.in',
        first_name: 'Tracey',
        last_name: 'Ramos',
        avatar: 'https://s3.amazonaws.com/uifaces/faces/twitter/bigmancho/128.jpg'
      }
    ]
  }
});
