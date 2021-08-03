<template>
    <div class="projects">
      <div class="project-item">
        <a href="single-project.html">
          <img src="../assets/img1.jpeg" />
        </a>
        <h2 class="title">
          <a href="#">Emotions</a>
        </h2>
      </div>

      <div class="project-item">
        <a href="single-project.html">
          <img src="../assets/img2.jpeg" />
        </a>
        <h2 class="title">
          <a href="#">Mountain</a>
        </h2>
      </div>

      <div class="project-item">
        <a href="single-project.html">
          <img src="../assets/img3.jpeg" />
        </a>
        <h2 class="title">
          <a href="#">Interface</a>
        </h2>
      </div>

      <div class="project-item">
        <a href="single-project.html">
          <img src="../assets/img4.jpeg" />
        </a>
        <h2 class="title">
          <a href="#">Transportation</a>
        </h2>
      </div>

      <div class="project-item">
        <a href="single-project.html">
          <img src="../assets/img5.jpeg" />
        </a>
        <h2 class="title">
          <a href="#">Perspective</a>
        </h2>
      </div>

      <div class="project-item">
        <a href="single-project.html">
          <img src="../assets/img6.jpeg" />
        </a>
        <h2 class="title">
          <a href="#">Mixilicious</a>
        </h2>
      </div>

      <div class="project-item">
        <a href="single-project.html">
          <img src="../assets/img7.jpeg" />
        </a>
        <h2 class="title">
          <a href="#">Creative</a>
        </h2>
      </div>

      <div class="project-item">
        <a href="single-project.html">
          <img src="../assets/img8.jpeg" />
        </a>
        <h2 class="title">
          <a href="#">Stapler</a>
        </h2>
      </div>

      <!-- Pagination -->
      <div class="pagination-wrap">
        <ul>
          <li>
            <a class="prev page-numbers" href="#">
              <i class="fa fa-long-arrow-left"></i>
            </a>
          </li>
          <li>
            <a class="page-numbers" href="#">1</a>
          </li>
          <li>
            <span class="page-numbers current">2</span>
          </li>
          <li>
            <a class="page-numbers" href="#">3</a>
          </li>
          <li>
            <a class="page-numbers" href="#">4</a>
          </li>
          <li>
            <a class="next page-numbers" href="#">
              <i class="fa fa-long-arrow-right"></i>
            </a>
          </li>
        </ul>

      </div>
      <!-- End Pagination -->
    </div>
</template>

<script>
export default {
  name: 'Home',
  props: {
    msg: String
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
h3 {
  margin: 40px 0 0;
}
ul {
  list-style-type: none;
  padding: 0;
}
li {
  display: inline-block;
  margin: 0 10px;
}
a {
  color: #42b983;
}
</style>
