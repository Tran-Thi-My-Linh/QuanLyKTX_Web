var countCol;  //column number of chart
var colWidth;  //width of a column
var spaceRow;
var maxLv;
function init() {
  countCol=myChart.colData.Data.length;
  colWidth=myChart.colData.width;
  maxLv=maxLevel(myChart);
  spaceRow=myChart.colData.spaceRow;

}
function drawChart() {
  init();
  setAuTo_WidthHeight();
  drawLineRow();
  drawRec();
  drawTextNote();
  drawTextTitleBot();
  drawTextTileTop();
  drawTextTileLeft();
}

function setAuTo_WidthHeight() {
  var height=120*(maxLv);
  var width=400+(150*countCol);
  myCanvans.width=width;
  myCanvans.height=height;
}

function  maxLevel(myChart) {
  var maxlv=Number.MIN_VALUE;
  var i;
  var item;
  for(i=0;i<countCol;i++){
    item=myChart.colData.Data[i].value;
    if(item>maxlv) {
      maxlv =item;
    }
  }
  return maxlv;
}
function drawLineRow() {
  var lengLine=(colWidth+50)*countCol;
  var startX=200;
  var endX=startX+lengLine;
  var startY=100;
  var font="30px Arial";
  var i;
  for(i=0;i<=maxLv;i++){
    startY+=spaceRow ;
    drawText(maxLv-i,font,"#000",startX-50,startY+10 );
    if(i==maxLv) {
      drawLine(startX, startY, endX, startY, "#000");
      continue;
    }
    drawLine(startX,startY,endX,startY,"#e5e3e3");

  }
}
function drawLine(sX,sY,eX,eY,color) {
  ctx.beginPath();
  ctx.moveTo(sX, sY);
  ctx.lineTo(eX, eY);
  ctx.strokeStyle=color;
  ctx.closePath();
  ctx.stroke();
}
function drawRec() {
  var colvalue;
  var colName;
  var startX=50;
  var startY=150+(maxLv*spaceRow);
  for(var i=0;i<countCol;i++)
  {
    colvalue=myChart.colData.Data[i].value*spaceRow;
    colName=myChart.colData.Data[i].label;
    startX+=(colWidth+spaceRow);
    ctx.fillStyle=myChart.color.colcolor;
    ctx.fillRect(startX,startY,colWidth,-colvalue);
    ctx.fillStyle=myChart.color.collabel;
    ctx.fillText(colName,startX+35,startY+40);

  }
}
function drawText(content,font,color,sX,sY) {
  ctx.beginPath();
  ctx.font=font;
  ctx.fillStyle=color;
  ctx.fillText(content,sX,sY);
  ctx.closePath();
}
function drawTextTileLeft() {
  var startX=60;
  var startY=100;
  var font="italic 30px Arial";
  ctx.translate(-startX,startY+350);
  ctx.rotate(-0.5*Math.PI);
  drawText(myChart.titleLeft,font,"#858585",startX,startY);
}
function drawTextTileTop() {
  var startX=150;
  var startY=50;
  var font="40px Arial";
  drawText(myChart.title,font,"#000",startX,startY);
}
function drawTextNote() {
  var lengLine=(colWidth+50)*countCol;
  startX=lengLine+220;
  var startY=150;
  ctx.fillStyle=myChart.color.colcolor;
  ctx.fillRect(startX,startY,100,50);
  var arrTitle=myChart.titleLeft.trim().split(' ');
  ctx.fillStyle=myChart.color.collabel;
  startY+=50;
  for(item in arrTitle)
  {
    startY+=50;
    ctx.fillText(arrTitle[item],startX,startY);
  }

}
function drawTextTitleBot() {

  var startX=myCanvans.width/2-spaceRow;
  var startY=myCanvans.height-spaceRow;
  var font="italic 30px Arial";
  ctx.fillStyle=myChart.color.colcolor;
  drawText(myChart.titleBot,font,"#858585",startX,startY);
}


