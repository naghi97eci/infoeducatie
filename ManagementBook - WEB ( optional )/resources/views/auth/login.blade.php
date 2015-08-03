<!DOCTYPE html>
<html lang="en">
  <head>
   
            <title>CNDV Management Book</title>
            <link rel="stylesheet" href="/css/login.css" >
            <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap.min.css">
            
  </head>

  <body>

    <div class="container">

      <form  class="form-signin" method="POST" action="/auth/login">
      {!! csrf_field() !!}
        <h2 class="form-signin-heading">Va rugam sa va logati!</h2>
        <label for="inputEmail" class="sr-only">Email </label>
        <input type="email" id="inputEmail" class="form-control" placeholder="Email " required autofocus name="email" value="{{ old('email') }}">
        <label for="inputPassword" class="sr-only">Parola</label>
        <input type="password" id="inputPassword" name="password" class="form-control" placeholder="Parola" required>
        <div class="checkbox">
          <label>
            <input type="checkbox" value="remember-me"> Tine-ma minte
          </label>
        </div>
        <button class="btn btn-lg btn-primary btn-block" type="submit">Log in</button>
      </form>
    @if ($errors->any())
        @foreach ($errors as $error)
        <div class="alert alert-danger">
          {{ $error }}
        </div>
        @endforeach
    @endif
    </div> <!-- /container -->


   
  </body>
</html>
