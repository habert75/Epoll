pipeline {
  agent any

  stages {
    stage('Build') {
      steps {
        sh 'echo "Add code to build code here"'
    }
    }
    stage('Test') {
      steps {
        sh 'echo "Add code to test your project here"'
      }
    }
    stage('Deploy') {
      steps {
          echo 'Add code to deploy to environment'
      }
    }
  }
  post {
    always {
      echo "The end!!"
    }
  }
}

