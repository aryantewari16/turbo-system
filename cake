<html lang="en">
<head>
<meta charset="UTF-8">
<meta name="viewport" content="width=device-width, initial-scale=1">
<title>Cake Time 🎂</title>

<style>
body {
  background: #fff3f8;
  text-align: center;
  font-family: Poppins, sans-serif;
  padding-top: 40px;
}

.cake {
  font-size: 140px;
  cursor: pointer;
}

.hidden {
  display: none;
}

.confetti {
  font-size: 30px;
  animation: fall 2s infinite;
}

@keyframes fall {
  0% { transform: translateY(-50px); }
  100% { transform: translateY(600px); }
}

button {
  margin-top: 30px;
  padding: 15px 35px;
  border: none;
  border-radius: 30px;
  background: #ff6f91;
  color: #ffffff;
  font-size: 16px;
}
</style>
</head>

<body>

<h2>Tap the cake to cut 🎂</h2>

<div class="cake" onclick="cutCake()">🎂</div>

<p id="msg" class="hidden">Cake cut 🎉 Make a wish Disha 💖</p>
<div id="confetti" class="hidden confetti">🎊 🎊 🎊</div>

<button onclick="location.href='message.html'">Final Surprise 💌</button>

<script>
function cutCake() {
  document.getElementById("msg").classList.remove("hidden");
  document.getElementById("confetti").classList.remove("hidden");
}
</script>

</body>
</html>
